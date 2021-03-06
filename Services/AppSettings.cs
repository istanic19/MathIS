﻿using dbConn;
using MathIS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MathIS.Services
{
    [Serializable]
    public class AppSettings
    {
        #region Fields

        [NonSerialized()]
        private string _AppPath;

        private CDBConnection _connection;
        private static CDBConnection _conn;

        private int _precision;
        private static int _precisionDecimals;

        private List<CDBConnection> _connections;

        private DimensionSet _dimensions;
        private static DimensionSet _dim;

        #endregion

        #region Properties

        public string AppPath
        {
            get { return _AppPath; }
            set { _AppPath = value; }
        }

        public static CDBConnection Connection
        {
            get { return _conn; }
        }

        public static DimensionSet Dimensions
        {
            get { return _dim; }
        }

        public int Precision
        {
            get { return _precision; }
            set 
            { 
                _precision = value;
                _precisionDecimals = value;
            }
        }

        public static int PrecisionDecimals
        {
            get { return _precisionDecimals; }
        }



        #endregion

        #region Constructor, destructor and initialization

        static AppSettings()
        {
        }

        public AppSettings(string apppath)
        {
            _AppPath = apppath;
            _connections = new List<CDBConnection>();
            _precision = -1;
            _precisionDecimals = -1;

            _dimensions = new DimensionSet();
            _dim = new DimensionSet();
        }

        [OnDeserialized]
        void OnDeserialized(StreamingContext context)
        {
            _conn = _connection;
            _precisionDecimals = _precision;
            if (_connections == null)
                _connections = new List<CDBConnection>();
            if (_dimensions == null)
                _dimensions = new DimensionSet();
            _dim = _dimensions;
        }

        public void Dispose()
        {


        }


        #endregion

        #region Methods

        #region Static Methods

        public static AppSettings Load()
        {
            AppSettings postavke = null;

            IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            Stream fromStream = null;
            string path = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            try
            {
                fromStream = new FileStream(path + "\\settings.dat", FileMode.Open, FileAccess.Read, FileShare.Read);
                postavke = (AppSettings)formatter.Deserialize(fromStream);
                postavke.AppPath = path;
            }
            catch
            {
                postavke = new AppSettings(path);
            }
            finally
            {
                if (fromStream != null)
                    fromStream.Close();
            }


            return postavke;
        }


        #endregion

        public void Save()
        {
            _dimensions = _dim;
            IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            Stream toStream = null;
            try
            {
                toStream = new FileStream(AppPath + "\\settings.dat", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(toStream, this);
            }
            catch
            {
            }
            finally
            {
                if (toStream != null)
                    toStream.Close();
            }
        }

        public void SetConnection(CDBConnection connection)
        {

            if (_connections.FirstOrDefault(c => c.ConnectionString == connection.ConnectionString) == null)
            {
                _connections.Add(connection);
            }

            _connection = connection;
            _conn = _connection;
        }

        public static bool TestConnection(out string message)
        {
            message = "";

            if (Connection == null)
            {
                message = "Database connection not set!";
                return false;
            }

            return CDatabase.TestConnection(Connection, out message);

        }
        public bool TestAllConnections(out string message)
        {
            message = "";

            if (Connection == null)
            {
                message = "Database connection not set!";
                return false;
            }

            bool result = TestConnection(Connection, out message);

            if (result)
                return true;

            foreach (var con in _connections)
            {
                if (con.ConnectionString == Connection.ConnectionString)
                    continue;
                if (TestConnection(con, out message))
                {
                    SetConnection(con);
                    return true;
                }
            }

            return false;


        }
        public static bool TestConnection(CDBConnection connection, out string message)
        {
            message = "";

            SqlConnection sqlConn = null;

            try
            {
                sqlConn = new SqlConnection(connection.ConnectionString + string.Format("Connect Timeout={0}", 3));
                sqlConn.Open();

            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
            finally
            {
                if (sqlConn != null)
                {
                    if (sqlConn.State == ConnectionState.Open)
                        sqlConn.Close();

                    sqlConn.Dispose();
                }
            }

            return true;
        }
        
       
        public void Initialize()
        {

        }

        
        

        #endregion
    }
}

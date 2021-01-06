Dot product Vector * Vector => rezultat je skalar
Vektori moraju biti istih dimenzija

[a1 a2 a3] * [b1 b2 b3] = a1*b1 + a2*b2 + a3*b3

--------------------------------------------------  VVVVVVVVVVVVV

Matrix product Vector X Vector => rezultat je Matrica 
Vektori moraju biti istih dimenzija

[a1 a2 a3] X [b1 b2 b3] = | a1*b1  a1*b2  a1*b3 |
						  | a2*b1  a2*b2  a2*b3 |
						  | a3*b1  a3*b2  a3*b3 |
						  
--------------------------------------------------  VVVVVVVVVVVVV

Product Matrice i Vektora => rezultat je Vektor

| a11 a12 a13 .... a1n |  | x1 |     | a11*x1+a12*x2+a13*x3+ ... +a1n*xn|
| a21 a22 a23 .... a2n |  | x2 |	 | a21*x1+a22*x2+a23*x3+ ... +a2n*xn|
| a31 a32 a33 .... a3n |  | x3 |     | a31*x1+a32*x2+a33*x3+ ... +a3n*xn| 

| am1 am2 am3 .... amn |  | xn |     | am1*x1+am2*x2+am3*x3+ ... +amn*xn|

-------------------------------------------------- VVVVVVVVVVVVV

Produkt matrice i matrice je matrica. 
Broj kolona prve matrice mora biti jednak broju redova druge matrice:
Ako je A (m X r) matrica a B (r X n) matrica ONDA JE produke C  = A B (m X n) matrica

| a11 a12 a13 |     | b11 b12 b13 |      | a11*b11+a12*b21+a13*b31     a11*b12+a12*b22+a13*b32    a11*b13+a12*b23+a13*b33 |
| a21 a22 a23 |     | b21 b22 b23 |		 | a21*b11+a22*b21+a23*b31     a21*b12+a22*b22+a23*b32    a21*b13+a22*b23+a23*b33 |
					| b31 b32 b33 |
					
-------------------------------------------------- VVVVVVVVVVVVV

Produkt vektora i skalara je vektor (množe se sve komponente sa skalarom)

--------------------------------------------------

Produkt matrice i skalara je matrica (množe se sve komponente sa skalarom)

--------------------------------------------------

Zbroj vektora i vektora je vektor

--------------------------------------------------

Hermition operator, Hermition matrix => aij=*aji  (* - complex conjugat => 1+2j  njegov conjugate je 1-2j)
	Hermition matrix ima dijagonalu od realnih brojeva (aii = *aii samo ako je aii realni broj bez imaginarne komponente)
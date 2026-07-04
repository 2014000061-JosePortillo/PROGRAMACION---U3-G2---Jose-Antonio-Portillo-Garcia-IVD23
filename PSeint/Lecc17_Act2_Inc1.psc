Algoritmo Lecc17_Act2_Inc1
	Definir numeroFila, numeroColumnas Como Entero
	Definir matrizIdentidad Como Entero
	Dimension matrizIdentidad[4,4]
	
	Para numeroFila = 1 Hasta 4 Hacer
		Para numeroColumnas = 1 Hasta 4 Hacer
			Si numeroFila = numeroColumnas Entonces
				matrizIdentidad[numeroFila,numeroColumnas] = 1
			SiNo
				matrizIdentidad[numeroFila,numeroColumnas] = 0
			FinSi
		FinPara
	FinPara
	Escribir "Matriz Identidad"
	Para numeroFila = 1 Hasta 4 Hacer
		Para numeroColumnas = 1 Hasta 4 Hacer
			Escribir Sin Saltar matrizIdentidad[numeroFila,numeroColumnas], " "
		FinPara
		Escribir ""
	FinPara
FinAlgoritmo

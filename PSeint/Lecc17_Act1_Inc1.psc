Algoritmo Lecc17_Act1_Inc1
	Definir donas Como Cadena
	Dimension donas[2,4]

	donas[1,1] = "Chocolate"
	donas[1,2] = "Fresa"
	donas[1,3] = "Vainilla"
	donas[1,4] = "Glaseada"

	donas[2,1] = "Caramelo"
	donas[2,2] = "Cafe"
	donas[2,3] = "Limon"
	donas[2,4] = "Canela"
	
	Para fila = 1 Hasta 2 Hacer
		Para columna = 1 Hasta 4 Hacer
			Escribir Sin Saltar donas[fila,columna], " | "
		FinPara
		Escribir ""
	FinPara
FinAlgoritmo
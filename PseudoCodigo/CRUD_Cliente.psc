
Algoritmo CRUD_Cliente
	//Se debe crear la conexi�n con la base de datos.
	conectUsuario <- "admin"
	conectNombre <- "Admin"
	conectContra <- "123"
	Escribir "Hola querido cliente"
	Escribir "�Ya est� registrado?.. Responder si/no"
	Leer resultado
	Si resultado = "si" O resultado = "Si" O resultado = "SI" Entonces
		Escribir "Escriba su usuario"
		leer usuario
		Escribir "Esciba su contrase�a"
		leer contra
		Si usuario = conectUsuario Y contra = conectContra Entonces
			Escribir "Bienvenido " conectUsuario
			Escribir "�Desea actualizar o eliminar?"
			Leer respuesta
			Si respuesta = "actualizar" o respuesta = "Actualizar" o respuesta = "ACTUALIZAR" Entonces
				Escribir "Ingrese nuevo usuario"
				Leer usuarioActualizado
				Escribir "Ingrese nuevo nombre"
				Leer nombreActualizado
				Escribir "Ingrese nueva contrase�a"
				Leer contraActualizado
				//Asignando los nuevos valores a los par�metros de la conexi�n
				conectUsuario <- usuarioActualizado
				conectNombre <- nombreActualizado
				conectContra <- contraActualizado
				Escribir "Cambios realizados correctamente"
				Escribir conectUsuario
				Escribir  conectNombre
				//Ac� se deben guardar los cambios dentro se la bd
			FinSi
			Si respuesta = "eliminar" o respuesta = "Eliminar" o respuesta = "ELIMINAR" Entonces
				Escribir "Escriba su usuario y contrase�a para confirmar"
				Escribir "usuario"
				Leer usuarioDelete
				Escribir "contrase�a"
				Leer contraDelete
				Si usuarioDelete = conectUsuario y contraDelete = conectContra Entonces
					Escribir "Se ha eliminado correctamente"
					//Ac� se debe elimar en registro dentro de la bd
				FinSi
			SiNo
				Escribir "Opci�n inv�lida"
			FinSi
		SiNo
			Escribir  "Usuario y contrase�a incorrecto"
		FinSi
	SiNo
		Si resultado = "no" O resultado = "No" O resultado = "NO" Entonces
			Escribir "Llene los campos para registrarse"
			Escribir "Usuario"
			leer usuarioNuevo
			Escribir "Nombre"
			Leer nombreNuevo
			Escribir "Contrase�a"
			leer contraNuevo
			
			conectUsuario <- usuarioNuevo
			conectNombre <- nombreNuevo
			conectContra <- contraNuevo
			
			//Almacenar este registro dentro de la base de datos
			Escribir  "se ha registrado correctamente el usuario"
			Escribir  conectUsuario
		SiNo
			Escribir "Opci�n no v�lida"
		Fin Si
	Fin Si
FinAlgoritmo


Algoritmo CRUD_Cliente
	//Se debe crear la conexión con la base de datos.
	conectUsuario <- "admin"
	conectNombre <- "Admin"
	conectContra <- "123"
	Escribir "Hola querido cliente"
	Escribir "¿Ya está registrado?.. Responder si/no"
	Leer resultado
	Si resultado = "si" O resultado = "Si" O resultado = "SI" Entonces
		Escribir "Escriba su usuario"
		leer usuario
		Escribir "Esciba su contraseña"
		leer contra
		Si usuario = conectUsuario Y contra = conectContra Entonces
			Escribir "Bienvenido " conectUsuario
			Escribir "¿Desea actualizar o eliminar?"
			Leer respuesta
			Si respuesta = "actualizar" o respuesta = "Actualizar" o respuesta = "ACTUALIZAR" Entonces
				Escribir "Ingrese nuevo usuario"
				Leer usuarioActualizado
				Escribir "Ingrese nuevo nombre"
				Leer nombreActualizado
				Escribir "Ingrese nueva contraseña"
				Leer contraActualizado
				//Asignando los nuevos valores a los parámetros de la conexión
				conectUsuario <- usuarioActualizado
				conectNombre <- nombreActualizado
				conectContra <- contraActualizado
				Escribir "Cambios realizados correctamente"
				Escribir conectUsuario
				Escribir  conectNombre
				//Acá se deben guardar los cambios dentro se la bd
			FinSi
			Si respuesta = "eliminar" o respuesta = "Eliminar" o respuesta = "ELIMINAR" Entonces
				Escribir "Escriba su usuario y contraseña para confirmar"
				Escribir "usuario"
				Leer usuarioDelete
				Escribir "contraseña"
				Leer contraDelete
				Si usuarioDelete = conectUsuario y contraDelete = conectContra Entonces
					Escribir "Se ha eliminado correctamente"
					//Acá se debe elimar en registro dentro de la bd
				FinSi
			SiNo
				Escribir "Opción inválida"
			FinSi
		SiNo
			Escribir  "Usuario y contraseña incorrecto"
		FinSi
	SiNo
		Si resultado = "no" O resultado = "No" O resultado = "NO" Entonces
			Escribir "Llene los campos para registrarse"
			Escribir "Usuario"
			leer usuarioNuevo
			Escribir "Nombre"
			Leer nombreNuevo
			Escribir "Contraseña"
			leer contraNuevo
			
			conectUsuario <- usuarioNuevo
			conectNombre <- nombreNuevo
			conectContra <- contraNuevo
			
			//Almacenar este registro dentro de la base de datos
			Escribir  "se ha registrado correctamente el usuario"
			Escribir  conectUsuario
		SiNo
			Escribir "Opción no válida"
		Fin Si
	Fin Si
FinAlgoritmo

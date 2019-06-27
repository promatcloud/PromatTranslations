using System.Collections.Generic;
using Promat.Translations.Models;

namespace Promat.Translations.Tests.Integration
{
    public static class Repository
    {
        public static List<string> GetRealProblematicIn20190627List() =>
                new List<string>
                {
                        "Archivos de Texto Plano",
                        "Celda",
                        "Si",
                        "No",
                        "'{0}' debería ser una dirección de celda de Excel válida. Ej: A3",
                        "'{0}' debería ser una columna de Excel válida. Ej: AB",
                        "Ficheros",
                        "Fichero",
                        "Fecha Inicio",
                        "Fecha Fin",
                        "Abrir carpeta...",
                        "Abrir fichero...",
                        "Detalle",
                        "Valor",
                        "Guardar en Fichero"
                };
        public static List<string> GetNewsList()
        {
            return new List<string>
            {
                    "¡Destacadas!", "Nueva presentación con leyenda del gráfico \"Síntesis de reparto\"",
                    "Nueva presentación gráfica con iconos e imágenes", "Nuevo sistema de presentación de filtros de informes",
                    "Revisión de visibilidad de gráficas de informe \"Basic Report\"", "Comentarios personalizados al generar informe \"OneShot / Un Vistazo\"",
                    "Comentarios personalizados al generar informe \"Mi Historico (Estado)\"",
                    "Comentarios personalizados al generar informe \"Mi Historico (Lote)\"", "Versión: jueves, 29 de noviembre de 2018",
                    "Scroll en pantalla auditorías cuando no se cumple tamaño mínimo de pantalla",
                    "Informe \"Un Vistazo\" mostrar el numero del valor medio en gráfico por ciclo y estado",
                    "Identificar el número de cerda en gráfico \"datos por ciclo\" pasando el ratón por encima",
                    "Versión: martes, 27 de noviembre de 2018", "Optimización en sistema de instalación",
                    "Error al calcular rangos en informe \"Un Vistazo\"", "Versión: lunes, 26 de noviembre de 2018", "Revisión de traducciones",
                    "Mejoras de optimización y rendimiento", "La aplicación permite modificar las cajas de solo lectura",
                    "Error la intentar sacar un informe que no tiene datos                                                                                                                                                                                                         ",
                    "Versión: viernes, 16 de noviembre de 2018", "Mostrar el usuario con el que se conectó en la barra de la aplicación                                                                                                                                            ",
                    "Quitar hora de los informes y reducir tamaño de letra",
                    "Mostrar 5 columnas en las secciones de \"Informes\" y de \"Configuración\" del \"Panel de inicio\"",
                    "Incluir informes \"OneShot / Un Vistazo\", \"Mi Historico (Lote)\" y \"Mi Historico (Estado)\" en el menú \"Informes\"",
                    "Error en cálculo de perdidas en informe \"Mi Historico (Lote)\"", "Nuevo acceso a la captación de ecógrafo en Panel de Inicio",
                    "Error al seleccionar un valor inexistente durante una búsqueda en las cajas de ayuda",
                    "Poder indicar en informe \"OneShot / Un vistazo\" si se muestra el comentario",
                    "Poder indicar en informe \"Mi Historico (Estado)\" si se muestra el comentario",
                    "Poder indicar en informe \"Mi Historico (Lote)\" si se muestra el comentario", "Pantalla de gestión de comentarios de informes",
                    "Borrado múltiple de líenas en auditorías ", "No mostrar la hora de la fecha de medición en los selectores de auditoria",
                    "Al cambiar la fecha de medición no se refresca en el buscador", "Mensaje informativo al asignar una imagen a una empresa",
                    "Error al borrar Usuarios",
                    "Exportación y visualización aumentada de \"Indicador general de estado corporal\" e \"Indicador general de homogeneidad\"",
                    "Cambiar <= por símbolo combinado en informes                                                                                                                                      ",
                    "Cambiar literal \"m/m\" por \"mm\" en informes", "Error al guardar \"Mis Filtros\" en informe \"Mi Historico (Estado)\"",
                    "Error al guardar \"Mis Filtros\" en informe \"Mi Historico (Lote)\"",
                    "Error al guardar \"Mis Filtros\" en informe \"OneShot / Un Vistazo\"",
                    "Mostrar rango correcto centrado en \"Indicador general de estado corporal\"",
                    "Pantalla de errores en Excel que sea maximizable y redimensionable",
                    "Versión: jueves, 27 de septiembre de 2018", "Sistema de importación Excel Ecógrafo (Beta)",
                    "Versión: miércoles, 26 de septiembre de 2018", "Traspasar información de animales por lote de la granja a la auditoría al crearla                                                                                                                                                                   ", "Calculadora de un sólo lote llamar desde pantalla auditorías                                                                                                                     ", "Traducciones, optimizaciones y errores menores", "Nuevo campo tamaño lote en Granja", "Calculadora simple para un sólo lote", "Traducción opciones OneShot", "Versión: lunes, 24 de septiembre de 2018", "Migración aplicación a nuevo estandar Microsft FrameWork 4.7.2", "Validación de datos en tiempo real (mientras se escriben)", "Error en traducción de validadores                                                                                                                                      ", "Mostrar pregunta al abondonar la aplicación", "Captación excel comenzar el fila 2 por defecto                                                                                                                                             ", "Error en cálculo de media ponderada en límites con diferentes Grupos de Ciclo", "Error calculando limites para Multiparas en listados Condicion Corporal, Auditoría gráficos, Comparativa auditoría                                                                                                                                            ", "Error al pedir cambio de contraseña en siguiente inicio de sesión", "Indicador BoxPlot con ayuda incrustada", "Informe de dispersión", "Optimización de velocidad listados", "Nuevo listado \"Mi Histórico(estado)\"", "Gráfico de síntesis de reparto", "Ampliación de demografía ideal a 7+", "Nueva maquetación de informes de la aplicación", "Nuevo diseño listado \"Básico\"", "Nuevo listado \"One Shot\"", "Nuevo listado \"Mi Histórico(lote)\"", "Selector de temas que solo muestre la vista preliminar de la pantalla", "Eliminar menú \"anchor status\" para que no desconfigure grids", "Pantalla de genéticas bloquear las columnas para que no se muevan", "Pantalla de Genéticas pasar a cursiva las columnas de solo lectura", "Soporte para pantallas con escalado DPI Windows", "Error en redimensionamiento de reports en pantallas con escalado Windows", "No muestra el cargar configuración y guardar en Grids", "Nuevo diseño de Panel de Inicio", "Logotipo de empresa en listados OneShot, Mi Histórico y Básico", "Imágenes de logotipo configurable en empresa", "Versión: jueves, 28 de junio de 2018", "Implementación y uso de certificación de código. ", "Errorres y mejoras de rendimiento/renderización de pantallas", "Nuevo orden de introducción de datos de auditoría", "Buscador de auditorías que se inicie oculto a menos que el usuario especifique otro comportamiento", "En el panel de inicio mostrar la barra de desplazamiento debajo cuando la resolución de la pantalla sea pequeña", "Cambiar orden de auxiliares dentro del menú y poner antes el \"Estado\" que la \"Genética\"", "Poder crear auxiliares desde las pantallas de búsqueda asociadas", "No se muestran los colores en el encabezado de los limites de referencia de auditorías", "No vacía correctamente el estado en los límites de referencia de la pantalla genéticas", "Incluir en listado \"Mi Histórico\" el estado de la cerda y filtrar la información por estado de la cerda.", "Versión: jueves, 14 de junio de 2018", "No deja vaciar correctamente la información de granja y estado en los limites de referencia por genética", "Gráficos de listados básicos mismas tamaños de letra y leyendas que en pantalla y tamaño proporcional a las dimensiones del folio de impresión.", "Versión: viernes, 8 de junio de 2018", "En importador de Excel si el usuario tiene hojas vacías genera error", "Versión Beta de traducción al idioma francés", "Visión \"Mi Histórico\" con información en tiempo real", "No se activa el Guardar/Cancelar al modificar detalles de genéticas", "Error al realizar busquedas en los Grid con las cajas de ayuda", "Barra de botones \"Favoritos\" anclable y configurable a modo \"Barra de herramientas\"", "Agrupar la lista de mejoras por fecha en lugar de por fecha y hora", "Pantalla de Panel de Inicio para granjero", "Pantalla de Panel de Inicio para usuarios", "Nuevo diseño de aplicación", "No se posiciona el foco en la casilla de Login", "No se muestra el menú \"Acerca\"", "Borrar representación de límites EGD y EMD de la pantalla la auditoria", "Gráfico evolución por ciclo y estado. No ordena correctamente por estado", "Gráfico de media que aparezca el rango medio siempre centrado", "Incluir unidades en los ejes de los gráficos", "Gráfico BoxPlot. La columna de distribución aceptable debe ir en escala de grises", "Exportador Múltiple a Excel que renombre las columnas de límites según configuración elegida", "Traducciones varias", "Notificador de expiración de puesto vía email", "Diferente orden de conceptos de búsqueda en buscador de auditorías", "Visión \"Tiempo Real\" en formato asistente", "Mejoras visuales y de rendimiento", "Informes Tiempo Real poder guardar filtros", "Selector de hojas para importador de Excel", "Versión: jueves, 17 de mayo de 2018", "Implementación de derechos y control de acceso para \"Granjeros\", \"Técnicos\" y \"Nutricionistas\"", "Cuando solo se tiene derecho para consultar una granja que se cargue automaticamente al añadir una auditoría", "Sistema de ayudas e información para gráficos", "Presentación de patas de BoxPlot a misma altura que gráficos de barras", "En BoxPlot EGD cambios en colores parametrizables", "Revisión de titulos y encabezados de gráficos de la aplicación", "Incluir la descripción del filtro en los informes", "Representación del valor obtenido en el indicador de media (correcto, graso, etc.)", "Informe básico incluir literal \"Commentaries and advises\" para la información de comentario", "Cambio de diseño, rangos, etc. del indicador de Coeficiente de variación", "Interpretación de músculo (EGD) parametrizable (colores y descripciones de estados)", "Redimensionamiento automática de las pantallas de ayuda y selección de datos", "Validación de datos al navegar por los búscadores", "Sistema de instalación poder recuperar un puesto desactivado por código de instalación", "Poder guardar configuraciones del Exportador Múltiple a Excel", "Generación de aplicaciones de tipo TEST", "Informe básico incluir información del número de animales auditados y número de animales del lote", "Pantalla de auditía incluir la información del número de animales", "Desactivar funcionalidades de auditoría y genética cuando el buscador está vacío", "Filtro por información de detalle en estadísticas de auditoría", "Botón para plegar el árbol de seguridad", "Presentación de Roles de seguridad en formato Pestaña", "Exportación múltiple a Excel bloquea el cerrar la aplicación", "Exportación de Grids a Excel poder guardar configuraciones", "Sistema de notificación de fechas de expiración para los administradores de licencias", "Indicador de media nuevos límites y gama de colores", "Nuevos límites en gráfico de Coeficiente de variación", "Control de duplicidad de puestos en sistema de instalación y ejecución", "Gráficos barras referencias en forma de líneas finas horizontales de los porcentajes que se consideran correctos                                               ", "Versión: lunes, 2 de abril de 2018", "Errores menores, traducciones y optimización de aplicación", "Presentación de posibles errores durante el proceso de instalación", "Información de demografía ideal en pantalla de configuración", "Nueva estadística de evolución por ciclo y estado de las cerdas", "Estadísticas prefiltradas con información de auditoría actual", "Nuevas columnas en selector de auditorías", "Selector de Lotes para informe y búsquedas", "Nueva informe y pantalla de auditoría básica", "Eliminación de gráfico de estado corporal", "Nuevo informe que muestra en un solo gráfico los valores correctos", "EMD nuevo rango hasta Ideal", "Exportador de múltiples auditorías a Excel", "Botón para duplicar auditorías", "Valor mínimo BoxPlot EGD estipulado a 5", "Configuración de valores ideales para BoxPlot", "Gráfico BoxPlot nueva barra con valores ideales", "Cambio de cálculo de colores en indicador de media de auditorías", "Cambio de cálculo de rangos en indicador de media de auditorías", "Derechos de Acceso y Escritura en pantallas principales", "Filtro de auditorías por Grupo de ciclo", "Presentación de valores de la aplicación con un decimal", "Versión: miércoles, 14 de marzo de 2018", "Errores y mejoras de rendimiento", "Errores en traducciones", "NUEVO SISTEMA DE GESTIÓN DE LICENCIAS E INSTALACIONES EN: https://controlpanel.promatcloud.com", "Posibilidad de limitar el acceso de un usuario a los datos de determinadas granjas", "Versión: lunes, 26 de febrero de 2018", "Nuevo diseño de pantalla de auditorías", "Módulo de informes básico para auditoría", "Versión: jueves, 22 de febrero de 2018", "Errores y correcciones", "Nuevo filtro de selección múltiple de auditorías en estadísticas", "Característica para poder guardar y cargar filtros de consultas en estadísticas", "Botón para duplicar una genética", "NUEVO SISTEMA DE INSTALACIÓN EN ENTORNOS SIN DERECHOS DE ADMINISTRADOR", "Mejoras varias", "Asociar una genética a una granja", "Revisión de número de decimales en auditoría", "Característica para poder configurar límites por genética / estado en una granja determinada", "Gestión de operadores", "Indicador promedio", "Indicador coeficiente variación", "Versión: viernes, 29 de diciembre de 2017", "Ayudas en la introducción de datos", "Errores y mejoras de rendimientos", "Buscador avanzado de auditorías", "Limites por grupo de ciclo en lugar de por ciclo", "Pantalla de gestión de roles", "Estadística auditoría gráficos", "Estadística Auditoría detalle"
            };
        }
        public static string GetWord(string lang)
        {
            switch (lang)
            {
                case "es":
                    return "Hola";
                case "en":
                    return "Hello";
                case "fr":
                    return "Bonjour";
                case "it":
                    return "ciao";
                case "pt":
                    return "Olá";
                default:
                    return string.Empty;
            }
        }
        public static string GetWord2(string lang)
        {
            switch (lang)
            {
                case "es":
                    return "Adiós";
                case "en":
                    return "Goodbye";
                case "fr":
                    return "Au revoir";
                case "it":
                    return "Arrivederci";
                case "pt":
                    return "Até logo";
                default:
                    return string.Empty;
            }
        }
        public static string GetParagraph(string lang)
        {
            switch (lang)
            {
                case "es":
                    return @"Esto es un pequeño párrafo.

Espero que vaya como un cañón.

Cigüeña pequeña.";
                case "en":
                    return @"This is a small paragraph.

I hope it goes like a cannon.

Small stork.";
                case "fr":
                    return @"C'est un petit paragraphe.

J'espère que ça va comme un canon.

Petite cigogne.";
                case "it":
                    return @"Questo è un piccolo paragrafo.

Spero che vada come un cannone.

Piccola cicogna.";
                case "pt":
                    return @"Este é um pequeno parágrafo.

Espero que vá como um canhão.

Cegonha pequena.";
                default:
                    return string.Empty;
            }
        }
        public static string Get4000CharactersInSomeParagraphs(string lang)
        {
            switch (lang)
            {
                case "es":
                    return @"Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro.

Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro.

Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca.

Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas.

Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se.";
                case "en":
                    return @"And, seeing Don Quixote in that way, with signs of so much sadness, he said, Sabete, Sancho, who is not one man but another if he does nothing but another. All these drunkennessthats that happen to us are signs that Time must be calmed and things must be right for us; because it is not possible for evil or good to be durable, and from here it follows that, having long lasted evil, good is already near. So, you must not grieve for the misfortunes that happen to me, for you can't get part of them. And, seeing Don Quixote in that way, with signs of so much sadness, he said, Sabete, Sancho, who is not one man but another if he does nothing but another.

All these drunkennessthats that happen to us are signs that Time must be calmed and things must be right for us; because it is not possible for evil or good to be durable, and from here it follows that, having long lasted evil, good is already near. So, you must not grieve for the misfortunes that happen to me, for you can't get part of them. And, seeing Don Quixote in that way, with signs of so much sadness, he said, Sabete, Sancho, who is not one man but another if he does nothing but another.

All these drunkennessthats that happen to us are signs that Time must be calmed and things must be right for us; because it is not possible for evil or good to be durable, and from here it follows that, having long lasted evil, good is already near. So, you must not grieve for the misfortunes that happen to me, for you can't get part of them. And, seeing Don Quixote in that way, with signs of so much sadness, he said, Sabete, Sancho, who is not one man but another if he does nothing but another. All these drunkennessthats that happen to us are signs that Time must be calmed and things must be right for us; because it is not possible for evil or good to be durable, and from here it follows that, having long lasted evil, good is already near.

So, you must not grieve for the misfortunes that happen to me, for you can't get part of them. And, seeing Don Quixote in that way, with signs of so much sadness, he said, Sabete, Sancho, who is not one man but another if he does nothing but another. All these drunkennessthats that happen to us are signs that Time must be calmed and things must be right for us; because it is not possible for evil or good to be durable, and from here it follows that, having long lasted evil, good is already near. So, you must not grieve for the misfortunes that happen to me, for you can't get part of them.

And, seeing Don Quixote in that way, with signs of so much sadness, he said, Sabete, Sancho, who is not one man but another if he does nothing but another. All these drunkennessthats that happen to us are signs that Time must be calmed and things must be right for us; because it is not possible for evil or good to be durable, and from here it follows that, having long lasted evil, good is already near. So, you must not grieve for the misfortunes that happen to me, for you can't get part of them. And, seeing Don Quixote in that way, with signs of so much sadness, he said, Sabete, Sancho, who is not one man but another if he does nothing but another. All these drunkennessthats that happen to us are signs that Time must be calmed and things must be right for us; because it is not possible for evil or good to be durable, and from here it follows that, having long lasted evil, good is already near. So, you must not grieve for the misfortunes that happen to me, for you can't get part of them. And, seeing Don Quixote in that way, with signs of so much sadness, he said, Sabete, Sancho, who is not one man but another if he does nothing but another. All these drunkennessthats that happen to us are signs that Time must be calmed and things must be right for us; because it is not possible for evil or good to be durable, and from here it is.";
                case "fr":
                    return @"Et, voyant Don Quichotte de cette façon, avec des signes de tant de tristesse, il a dit, Sabete, Sancho, qui n'est pas un homme, mais un autre s'il ne fait rien, mais un autre. Toutes ces ivresse qui nous arrivent sont des signes que le temps doit être calmé et que les choses doivent être bonnes pour nous ; parce qu'il n'est pas possible pour le mal ou le bien d'être durable, et d'ici il s'ensuit que, après avoir longtemps duré le mal, le bien est déjà proche. Donc, vous ne devez pas pleurer pour les malheurs qui m'arrivent, car vous ne pouvez pas en faire partie. Et, voyant Don Quichotte de cette façon, avec des signes de tant de tristesse, il a dit, Sabete, Sancho, qui n'est pas un homme, mais un autre s'il ne fait rien, mais un autre.

Toutes ces ivresse qui nous arrivent sont des signes que le temps doit être calmé et que les choses doivent être bonnes pour nous ; parce qu'il n'est pas possible pour le mal ou le bien d'être durable, et d'ici il s'ensuit que, après avoir longtemps duré le mal, le bien est déjà proche. Donc, vous ne devez pas pleurer pour les malheurs qui m'arrivent, car vous ne pouvez pas en faire partie. Et, voyant Don Quichotte de cette façon, avec des signes de tant de tristesse, il a dit, Sabete, Sancho, qui n'est pas un homme, mais un autre s'il ne fait rien, mais un autre.

Toutes ces ivresse qui nous arrivent sont des signes que le temps doit être calmé et que les choses doivent être bonnes pour nous ; parce qu'il n'est pas possible pour le mal ou le bien d'être durable, et d'ici il s'ensuit que, après avoir longtemps duré le mal, le bien est déjà proche. Donc, vous ne devez pas pleurer pour les malheurs qui m'arrivent, car vous ne pouvez pas en faire partie. Et, voyant Don Quichotte de cette façon, avec des signes de tant de tristesse, il a dit, Sabete, Sancho, qui n'est pas un homme, mais un autre s'il ne fait rien, mais un autre. Toutes ces ivresse qui nous arrivent sont des signes que le temps doit être calmé et que les choses doivent être bonnes pour nous ; parce qu'il n'est pas possible pour le mal ou le bien d'être durable, et d'ici il s'ensuit que, après avoir longtemps duré le mal, le bien est déjà proche.

Donc, vous ne devez pas pleurer pour les malheurs qui m'arrivent, car vous ne pouvez pas en faire partie. Et, voyant Don Quichotte de cette façon, avec des signes de tant de tristesse, il a dit, Sabete, Sancho, qui n'est pas un homme, mais un autre s'il ne fait rien, mais un autre. Toutes ces ivresse qui nous arrivent sont des signes que le temps doit être calmé et que les choses doivent être bonnes pour nous ; parce qu'il n'est pas possible pour le mal ou le bien d'être durable, et d'ici il s'ensuit que, après avoir longtemps duré le mal, le bien est déjà proche. Donc, vous ne devez pas pleurer pour les malheurs qui m'arrivent, car vous ne pouvez pas en faire partie.

Et, voyant Don Quichotte de cette façon, avec des signes de tant de tristesse, il a dit, Sabete, Sancho, qui n'est pas un homme, mais un autre s'il ne fait rien, mais un autre. Toutes ces ivresse qui nous arrivent sont des signes que le temps doit être calmé et que les choses doivent être bonnes pour nous ; parce qu'il n'est pas possible pour le mal ou le bien d'être durable, et d'ici il s'ensuit que, après avoir longtemps duré le mal, le bien est déjà proche. Donc, vous ne devez pas pleurer pour les malheurs qui m'arrivent, car vous ne pouvez pas en faire partie. Et, voyant Don Quichotte de cette façon, avec des signes de tant de tristesse, il a dit, Sabete, Sancho, qui n'est pas un homme, mais un autre s'il ne fait rien, mais un autre. Toutes ces ivresse qui nous arrivent sont des signes que le temps doit être calmé et que les choses doivent être bonnes pour nous ; parce qu'il n'est pas possible pour le mal ou le bien d'être durable, et d'ici il s'ensuit que, après avoir longtemps duré le mal, le bien est déjà proche. Donc, vous ne devez pas pleurer pour les malheurs qui m'arrivent, car vous ne pouvez pas en faire partie. Et, voyant Don Quichotte de cette façon, avec des signes de tant de tristesse, il a dit, Sabete, Sancho, qui n'est pas un homme, mais un autre s'il ne fait rien, mais un autre. Toutes ces ivresse qui nous arrivent sont des signes que le temps doit être calmé et que les choses doivent être bonnes pour nous ; parce qu'il n'est pas possible pour le mal ou le bien d'être durable, et d'ici il est.";
                case "it":
                    return @"E, vedendo Don Chisciotte in quel modo, con segni di tanta tristezza, disse, Sabete, Sancho, che non è un uomo ma un altro se non fa altro che un altro. Tutta questa ubriachezza che ci capita sono segni che il Tempo deve essere calmato e le cose devono essere giuste per noi; perché non è possibile che il male o il bene siano durevoli, e da qui ne consegue che, avendo durato a lungo il male, il bene è già vicino. Quindi, non devi soffrire per le disgrazie che mi succedono, perché non puoi farne parte. E, vedendo Don Chisciotte in quel modo, con segni di tanta tristezza, disse, Sabete, Sancho, che non è un uomo ma un altro se non fa altro che un altro.

Tutta questa ubriachezza che ci capita sono segni che il Tempo deve essere calmato e le cose devono essere giuste per noi; perché non è possibile che il male o il bene siano durevoli, e da qui ne consegue che, avendo durato a lungo il male, il bene è già vicino. Quindi, non devi soffrire per le disgrazie che mi succedono, perché non puoi farne parte. E, vedendo Don Chisciotte in quel modo, con segni di tanta tristezza, disse, Sabete, Sancho, che non è un uomo ma un altro se non fa altro che un altro.

Tutta questa ubriachezza che ci capita sono segni che il Tempo deve essere calmato e le cose devono essere giuste per noi; perché non è possibile che il male o il bene siano durevoli, e da qui ne consegue che, avendo durato a lungo il male, il bene è già vicino. Quindi, non devi soffrire per le disgrazie che mi succedono, perché non puoi farne parte. E, vedendo Don Chisciotte in quel modo, con segni di tanta tristezza, disse, Sabete, Sancho, che non è un uomo ma un altro se non fa altro che un altro. Tutta questa ubriachezza che ci capita sono segni che il Tempo deve essere calmato e le cose devono essere giuste per noi; perché non è possibile che il male o il bene siano durevoli, e da qui ne consegue che, avendo durato a lungo il male, il bene è già vicino.

Quindi, non devi soffrire per le disgrazie che mi succedono, perché non puoi farne parte. E, vedendo Don Chisciotte in quel modo, con segni di tanta tristezza, disse, Sabete, Sancho, che non è un uomo ma un altro se non fa altro che un altro. Tutta questa ubriachezza che ci capita sono segni che il Tempo deve essere calmato e le cose devono essere giuste per noi; perché non è possibile che il male o il bene siano durevoli, e da qui ne consegue che, avendo durato a lungo il male, il bene è già vicino. Quindi, non devi soffrire per le disgrazie che mi succedono, perché non puoi farne parte.

E, vedendo Don Chisciotte in quel modo, con segni di tanta tristezza, disse, Sabete, Sancho, che non è un uomo ma un altro se non fa altro che un altro. Tutta questa ubriachezza che ci capita sono segni che il Tempo deve essere calmato e le cose devono essere giuste per noi; perché non è possibile che il male o il bene siano durevoli, e da qui ne consegue che, avendo durato a lungo il male, il bene è già vicino. Quindi, non devi soffrire per le disgrazie che mi succedono, perché non puoi farne parte. E, vedendo Don Chisciotte in quel modo, con segni di tanta tristezza, disse, Sabete, Sancho, che non è un uomo ma un altro se non fa altro che un altro. Tutta questa ubriachezza che ci capita sono segni che il Tempo deve essere calmato e le cose devono essere giuste per noi; perché non è possibile che il male o il bene siano durevoli, e da qui ne consegue che, avendo durato a lungo il male, il bene è già vicino. Quindi, non devi soffrire per le disgrazie che mi succedono, perché non puoi farne parte. E, vedendo Don Chisciotte in quel modo, con segni di tanta tristezza, disse, Sabete, Sancho, che non è un uomo ma un altro se non fa altro che un altro. Tutta questa ubriachezza che ci capita sono segni che il Tempo deve essere calmato e le cose devono essere giuste per noi; perché non è possibile che il male o il bene siano durevoli, e da qui lo è.";
                case "pt":
                    return @"E, vendo Dom Quixote dessa forma, com sinais de tanta tristeza, disse ele, Sabete, Sancho, que não é um só homem senão outro se não fizer nada senão outro. Todos esses bêbados que acontecem conosco são sinais de que o tempo deve ser acalmado e as coisas devem ser certas para nós; Porque não é possível para o mal ou bom ser durável, e a partir daqui, segue-se que, tendo durado muito mal, o bem já está perto. Então, você não deve lamentar pelas infortúnios que acontecem comigo, pois você não pode obter parte deles. E, vendo Dom Quixote dessa forma, com sinais de tanta tristeza, disse ele, Sabete, Sancho, que não é um só homem senão outro se não fizer nada senão outro.

Todos esses bêbados que acontecem conosco são sinais de que o tempo deve ser acalmado e as coisas devem ser certas para nós; Porque não é possível para o mal ou bom ser durável, e a partir daqui, segue-se que, tendo durado muito mal, o bem já está perto. Então, você não deve lamentar pelas infortúnios que acontecem comigo, pois você não pode obter parte deles. E, vendo Dom Quixote dessa forma, com sinais de tanta tristeza, disse ele, Sabete, Sancho, que não é um só homem senão outro se não fizer nada senão outro.

Todos esses bêbados que acontecem conosco são sinais de que o tempo deve ser acalmado e as coisas devem ser certas para nós; Porque não é possível para o mal ou bom ser durável, e a partir daqui, segue-se que, tendo durado muito mal, o bem já está perto. Então, você não deve lamentar pelas infortúnios que acontecem comigo, pois você não pode obter parte deles. E, vendo Dom Quixote dessa forma, com sinais de tanta tristeza, disse ele, Sabete, Sancho, que não é um só homem senão outro se não fizer nada senão outro. Todos esses bêbados que acontecem conosco são sinais de que o tempo deve ser acalmado e as coisas devem ser certas para nós; Porque não é possível para o mal ou bom ser durável, e a partir daqui, segue-se que, tendo durado muito mal, o bem já está perto.

Então, você não deve lamentar pelas infortúnios que acontecem comigo, pois você não pode obter parte deles. E, vendo Dom Quixote dessa forma, com sinais de tanta tristeza, disse ele, Sabete, Sancho, que não é um só homem senão outro se não fizer nada senão outro. Todos esses bêbados que acontecem conosco são sinais de que o tempo deve ser acalmado e as coisas devem ser certas para nós; Porque não é possível para o mal ou bom ser durável, e a partir daqui, segue-se que, tendo durado muito mal, o bem já está perto. Então, você não deve lamentar pelas infortúnios que acontecem comigo, pois você não pode obter parte deles.

E, vendo Dom Quixote dessa forma, com sinais de tanta tristeza, disse ele, Sabete, Sancho, que não é um só homem senão outro se não fizer nada senão outro. Todos esses bêbados que acontecem conosco são sinais de que o tempo deve ser acalmado e as coisas devem ser certas para nós; Porque não é possível para o mal ou bom ser durável, e a partir daqui, segue-se que, tendo durado muito mal, o bem já está perto. Então, você não deve lamentar pelas infortúnios que acontecem comigo, pois você não pode obter parte deles. E, vendo Dom Quixote dessa forma, com sinais de tanta tristeza, disse ele, Sabete, Sancho, que não é um só homem senão outro se não fizer nada senão outro. Todos esses bêbados que acontecem conosco são sinais de que o tempo deve ser acalmado e as coisas devem ser certas para nós; Porque não é possível para o mal ou bom ser durável, e a partir daqui, segue-se que, tendo durado muito mal, o bem já está perto. Então, você não deve lamentar pelas infortúnios que acontecem comigo, pois você não pode obter parte deles. E, vendo Dom Quixote dessa forma, com sinais de tanta tristeza, disse ele, Sabete, Sancho, que não é um só homem senão outro se não fizer nada senão outro. Todos esses bêbados que acontecem conosco são sinais de que o tempo deve ser acalmado e as coisas devem ser certas para nós; Porque não é possível para o mal ou bom ser durável, e a partir daqui é.";
                default:
                    return string.Empty;
            }
        }

        public static string Get6093CharactersInsomeParagraphs(string lang)
        {
            switch (lang)
            {
                case "es":
                    return @"Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas.

Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas.

Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas.

Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas.

Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que";
                case "en":
                    return @"And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas.

And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas.

And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas.

And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas.

And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that";
                default:
                    return string.Empty;
            }
        }
        public static string Get6093CharactersInOneParagraph(string lang)
        {
            switch (lang)
            {
                case "es":
                    return @"Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe parte dellas. Y, viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que";
                case "en":
                    return @"And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that the evil or good are durable, and from here it follows that, having lasted much evil, good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that";
                default:
                    return string.Empty;
            }
        }
        public static List<List<TranslationInfo>> Get6093CharactersInOneParagraphSimulatedRawResponse(string lang)
        {
            switch (lang)
            {
                case "en":
                    return new List<List<TranslationInfo>>
                    {
                            new List<TranslationInfo>
                            {
                                    new TranslationInfo(lang, @"And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that the"),
                            },
                            new List<TranslationInfo>
                            {
                                    new TranslationInfo(lang, @"Evil or good are durable, and from here it follows that, having lasted much evil, good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that"),
                            }
                    };
                default:
                    return null;
            }
        }
        public static List<List<TranslationInfo>> GetNovedadesAndMoreSimulatedRawResponse(string lang)
        {
            switch (lang)
            {
                case "en":
                    return new List<List<TranslationInfo>>
                    {
                            new List<TranslationInfo>
                            {
                                    new TranslationInfo(lang, @"| 1 | This would be the first
text to translate
| 2 | This would be the second.
| 3 | Nothing more
| 4 | More things
| 5 |"),
                            },
                            new List<TranslationInfo>
                            {
                                    new TranslationInfo(lang, @"| 6 | featured!
New presentation with the 'Synthesis of cast' chart legend
New graphic presentation with icons and images
New system of report filters
Review of visibility graphs of 'Basic Report' report
Comments custom when generating report ' OneShot / a look '
Comments custom when generating report 'My historical (State)'
Comments custom when generating report 'My historical (lot)'
Version: Thursday, November 29, 2018
Scroll on-screen audits when not met minimum screen size
'A look' report show the number of graph-average value per cycle and State
Identify the number of bristle in graphic 'data per cycle' passing the mouse over
Version: Tuesday, November 27, 2018
Optimization on installation
Failed to calculate ranges in the report 'A look'
Version: Monday, November 26, 2018
Review of translations
Optimization and performance improvements
The application allows you to modify read-only boxes
Error try it to get a report that has no data
Version: Friday, November 16, 2018
Show the user which was connected in the application bar
Remove time for reports and reduce font size
Show 5 columns in the sections 'Reports' and 'Setup' home 'Panel'
Include reports ' OneShot / a look ', 'My historical (lot)' and 'My historical (State)' in the 'Reports' menu
Error in calculation of losses in 'My historical (lot)' report
New access to the Ultrasound in home Panel captation
Error when you select a non-existent value during a search in the boxes of aid
Be able to indicate in the report ' OneShot / out ' if the comment is displayed
Be able to indicate in 'My historical (State)' report if the comment is displayed
Be able to indicate in 'My historical (lot)' report if the comment is displayed
Reviews of reports management screen
Deleting multiple lienas audits
Does not display the time of the date of measurement in audit selectors
To change the date of measurement does not cool in the search box
Informative message to assign an image to a company
Error deleting users
Export and display of 'General body status indicator' and 'General indicator of homogeneity'
Change &lt; = symbol combined reports
Change literal'm '/ m 'mm' reports
Error saving 'My filters' report 'My historical (State)'
Error saving 'My filters' report 'My historical (lot)'
Error saving 'My filters' report ' OneShot / a look '
Show correct range focused on 'General body status indicator'
Errors in Excel that is maximizable and Resizable screen
Version: Thursday, September 27, 2018
Import Excel Ultrasound (Beta) system
Version: Wednesday, September 26, 2018
Pass information of animals batch farm audit to create it
Calculator of a lot called only from display audits
Translations, optimizations and minor errors
New field size lot on farm
Simple calculator for a just lot
Translation options OneShot
Version: Monday, September 24, 2018
Migration to new standard Microsft FrameWork 4.7.2 application
Data validation in real-time (as written)
Error in translation of validators
Show ask the ditching of the application
Recruitment excel begin row 2 by default
Error in calculation of average weighted limits with different groups of cycle
Error calculating limits to Multiparas listed body condition, audit charts, comparative audit
Error calling for change of password at next start of session
Indicator BoxPlot with embedded help
Report of dispersion
Listed speed optimization
New listing 'My historical (State)'
Synthesis of cast graph
Ideal demographics to 7 + large
New layout of the implementation reports
New design list 'Basic'
New listing 'One Shot'
New listing 'My historical (lote)'
Themes selector that only shows the screen preview
Remove menu 'anchor status' so not you Unconfigure grids
Genetic screen block columns so that they do not move
Genetic screen pass to italic read-only columns
Support for screens with scaled DPI Windows
Error in reports on screens with scaling Windows resizing
Does not display the load settings and save in Grids
New Panel of home design
Company's logo in the OneShot, my historic and basic listings
Images of customizable company logo
Version: Thursday, June 28, 2018
Implementation and use of certification of code.
Errors and improvements of performance/rendering screens
New order of introduction of audit data
Search for audits to start hidden unless the user specifies another"),
                            },
                            new List<TranslationInfo>
                            {
                                    new TranslationInfo(lang, @"behavior
In the home panel display scrollbar below when the screen resolution is small
Change order of auxiliary within the menu and get the 'State' to 'Genetics'
To create auxiliary associated search screens
Not shown in the header colors of limits of reference of audits
Not empty properly the State within the limits of the genetic screen reference
Include the State of bristle in my historical listing and filter information by State of bristle.
Version: Thursday, June 14, 2018
Doesn't properly drain the farm and status information in the reference limits for Genetics
Graphics listed same basic sizes of lyrics and legends that display and size proportional to the dimensions of the printing sheet.
Version: Friday, June 8, 2018
Importer of Excel if the user has empty leaves it generates error
Beta version of the French language translation
My historical view with information in real time
Does not activate the Save / Cancel to modify details of genetic
Error when performing searches on the Grid with support boxes
Toolbar buttons 'favorito' that can be fixed, configurable mode 'Toolbar'
Group the list of improvements by date instead of by date and time
Home Panel screen for farmer
Home Panel screen for users
New application design
Do not focus on the Login box is positioned
The 'About' menu is not displayed
Clear representation of EGD and EMD of the screen limits the audit
Graphic evolution cycle and status. Do not sort properly by State
Graphic media appearing in the Middle always focused range
Include units in the axes of graphs
Graphic BoxPlot.La acceptable distribution column must be in grayscale
Multiple exporter to Excel that rename the columns of limits depending on chosen configuration
Several translations
Expiration of post via email notifier
Different order of search in search engine terms of audits
View 'Real time' in Wizard format
Visual and performance improvements
Real time reports to save filters
Importer of Excel sheet selector
Version: Thursday, May 17, 2018
Implementation of rights and control of access to 'Farmers', 'Technical' and 'Nutritionists'
When only has the right to consult a farm that is loaded automatically by adding an audit
System of supports and information graphics
Presentation of BoxPlot legs to same height as bar charts
In BoxPlot EGD changes in colors customizable
Review of titles and headlines of the application graphics
Include the description of the filter in reports
Representation of the value obtained in the average indicator (right, fat, etc.)
Basic report include literal ' Commentaries and advises' for comment information
Change of design, ranges of coefficient of variation indicator etc.del
Interpretation of muscle (EGD) customizable (colors and descriptions of States)
Automatic resizing of the help and data selection screens
Validation of data when browsing through the search engines
Installation system to retrieve a post off by installation code
To save configurations of Multiple export to Excel
Generation of TEST-type applications
Review basic to include the number of audited animals and animals of the lot number information
Auditia screen include the information of the number of animals
Disable auditing and genetics capabilities when the search box is empty
Filter by detail in statistics of audit information
Button to collapse the security tree
Presentation of the Roles of security format tab
Multiple export to Excel blocks closing the application
Export from Grids to Excel to save settings
System of notification of expiration dates for licensing administrators
Indicator of average new limits and range of colours
New limits on coefficient of variation chart
Control duplication of jobs in installation and execution system
Graphics bar references in the form of percentages that are considered correct horizontal thin lines
Version: 2 April 2018
Minor bugs, translations and application optimization
Presentation of possible errors during the installation process
Ideal demographics in Setup screen information
New statistics of evolution cycle and sows status
Statistics prefiltradas with current audit information
New columns in audit collector
Lots selector to search and report
New report and basic audit screen
Elimination of bodily state graph
New report that shows the correct values on a single chart
New EMD range up to Ideal"),
                            },
                            new List<TranslationInfo>
                            {
                                    new TranslationInfo(lang, @"Exporter of multiple audits to Excel
Button to double audits
Minimum value BoxPlot EGD stipulated to 5
Configuration of ideal values for BoxPlot
Graphic BoxPlot new bar with ideal values
Change of calculation of colors in audits average indicator
Change of calculation of ranges in audits average indicator
Rights of access and write main screens
Filter by group of cycle audits
Presentation of the application to one decimal place values
Version: Wednesday, March 14, 2018
Errors and performance improvements
Errors in translations
NEW system of management of licenses and installations in: https://controlpanel.promatcloud.com
Possibility of limiting a user's access to data from certain farms
Version: Monday, February 26, 2018
New audit screen design
Basic reporting module for audit
Version: Thursday, February 22, 2018
Errors and corrections
New filter multiple selection of audits in statistics
Feature to be able to save and load queries against statistics filters
Button to duplicate a genetic
NEW SYSTEM INSTALLATION IN ENVIRONMENTS WITHOUT ADMINISTRATOR RIGHTS
Several improvements
A genetics associated with a farm
Number of decimal places in audit review
Feature to configure limits by Genetics / State on a particular farm
Operators management
Average indicator
Indicator coefficient variation
Version: Friday, December 29, 2017
Aid in the introduction of data
Errors and performance improvements
Advanced search of audits
Limits by cycle rather than by cycle group
Roles management screen
Statistical audit graphics
Statistical audit detail"),
                            },
                            new List<TranslationInfo>
                            {
                                    new TranslationInfo(lang, @"| 7 | Last thing to translate;."),
                            }
                    };
                default:
                    return null;
            }
        }
        public static List<List<TranslationInfo>> Get6093CharactersInsomeParagraphsSimulatedRawResponse(string lang)
        {
            switch (lang)
            {
                case "en":
                    return new List<List<TranslationInfo>>
                    {
                            new List<TranslationInfo>
                            {
                                    new TranslationInfo(lang, @"And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas."),
                            },
                            new List<TranslationInfo>
                            {
                                    new TranslationInfo(lang, @"And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas."),
                            },
                            new List<TranslationInfo>
                            {
                                    new TranslationInfo(lang, @"And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas."),
                            },
                            new List<TranslationInfo>
                            {
                                    new TranslationInfo(lang, @"And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas."),
                            },
                            new List<TranslationInfo>
                            {
                                    new TranslationInfo(lang, @"And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that, having lasted much evil, the good is already near. So, you should not congojarte by the misfortunes that happen to me, because you do not have part Dellas. And, seeing Don Quixote in that way, with such sadness, he said to him, know, Sancho, that he is not a man more than another if he does nothing but another. All these storms that happen to us are signs that Presto has to calm the time and things have to happen well; Because it is not possible that evil or good are durable, and from here it follows that"),
                            }
                    };
                default:
                    return null;
            }
        }
        public static string GetFarmingControlNovedades() => @"¡Destacadas!
Nueva presentación con leyenda del gráfico 'Síntesis de reparto'
Nueva presentación gráfica con iconos e imágenes
Nuevo sistema de presentación de filtros de informes
Revisión de visibilidad de gráficas de informe 'Basic Report'
Comentarios personalizados al generar informe 'OneShot / Un Vistazo'
Comentarios personalizados al generar informe 'Mi Historico (Estado)'
Comentarios personalizados al generar informe 'Mi Historico (Lote)'
Versión: jueves, 29 de noviembre de 2018
Scroll en pantalla auditorías cuando no se cumple tamaño mínimo de pantalla
Informe 'Un Vistazo' mostrar el numero del valor medio en gráfico por ciclo y estado
Identificar el número de cerda en gráfico 'datos por ciclo' pasando el ratón por encima
Versión: martes, 27 de noviembre de 2018
Optimización en sistema de instalación
Error al calcular rangos en informe 'Un Vistazo'
Versión: lunes, 26 de noviembre de 2018
Revisión de traducciones
Mejoras de optimización y rendimiento
La aplicación permite modificar las cajas de solo lectura
Error la intentar sacar un informe que no tiene datos
Versión: viernes, 16 de noviembre de 2018
Mostrar el usuario con el que se conectó en la barra de la aplicación
Quitar hora de los informes y reducir tamaño de letra
Mostrar 5 columnas en las secciones de 'Informes' y de 'Configuración' del 'Panel de inicio'
Incluir informes 'OneShot / Un Vistazo', 'Mi Historico (Lote)' y 'Mi Historico (Estado)' en el menú 'Informes'
Error en cálculo de perdidas en informe 'Mi Historico (Lote)'
Nuevo acceso a la captación de ecógrafo en Panel de Inicio
Error al seleccionar un valor inexistente durante una búsqueda en las cajas de ayuda
Poder indicar en informe 'OneShot / Un vistazo' si se muestra el comentario
Poder indicar en informe 'Mi Historico (Estado)' si se muestra el comentario
Poder indicar en informe 'Mi Historico (Lote)' si se muestra el comentario
Pantalla de gestión de comentarios de informes
Borrado múltiple de líenas en auditorías
No mostrar la hora de la fecha de medición en los selectores de auditoria
Al cambiar la fecha de medición no se refresca en el buscador
Mensaje informativo al asignar una imagen a una empresa
Error al borrar Usuarios
Exportación y visualización aumentada de 'Indicador general de estado corporal' e 'Indicador general de homogeneidad'
Cambiar <= por símbolo combinado en informes
Cambiar literal 'm/m' por 'mm' en informes
Error al guardar 'Mis Filtros' en informe 'Mi Historico (Estado)'
Error al guardar 'Mis Filtros' en informe 'Mi Historico (Lote)'
Error al guardar 'Mis Filtros' en informe 'OneShot / Un Vistazo'
Mostrar rango correcto centrado en 'Indicador general de estado corporal'
Pantalla de errores en Excel que sea maximizable y redimensionable
Versión: jueves, 27 de septiembre de 2018
Sistema de importación Excel Ecógrafo(Beta)
Versión: miércoles, 26 de septiembre de 2018
Traspasar información de animales por lote de la granja a la auditoría al crearla
Calculadora de un sólo lote llamar desde pantalla auditorías
Traducciones, optimizaciones y errores menores
Nuevo campo tamaño lote en Granja
Calculadora simple para un sólo lote
Traducción opciones OneShot
Versión: lunes, 24 de septiembre de 2018
Migración aplicación a nuevo estandar Microsft FrameWork 4.7.2
Validación de datos en tiempo real(mientras se escriben)
Error en traducción de validadores
Mostrar pregunta al abondonar la aplicación
Captación excel comenzar el fila 2 por defecto
Error en cálculo de media ponderada en límites con diferentes Grupos de Ciclo
Error calculando limites para Multiparas en listados Condicion Corporal, Auditoría gráficos, Comparativa auditoría
Error al pedir cambio de contraseña en siguiente inicio de sesión
Indicador BoxPlot con ayuda incrustada
Informe de dispersión
Optimización de velocidad listados
Nuevo listado 'Mi Histórico(estado)'
Gráfico de síntesis de reparto
Ampliación de demografía ideal a 7+
Nueva maquetación de informes de la aplicación
Nuevo diseño listado 'Básico'
Nuevo listado 'One Shot'
Nuevo listado 'Mi Histórico(lote)'
Selector de temas que solo muestre la vista preliminar de la pantalla
Eliminar menú 'anchor status' para que no desconfigure grids
Pantalla de genéticas bloquear las columnas para que no se muevan
Pantalla de Genéticas pasar a cursiva las columnas de solo lectura
Soporte para pantallas con escalado DPI Windows
Error en redimensionamiento de reports en pantallas con escalado Windows
No muestra el cargar configuración y guardar en Grids
Nuevo diseño de Panel de Inicio
Logotipo de empresa en listados OneShot, Mi Histórico y Básico
Imágenes de logotipo configurable en empresa
Versión: jueves, 28 de junio de 2018
Implementación y uso de certificación de código.
Errorres y mejoras de rendimiento/renderización de pantallas
Nuevo orden de introducción de datos de auditoría
Buscador de auditorías que se inicie oculto a menos que el usuario especifique otro comportamiento
En el panel de inicio mostrar la barra de desplazamiento debajo cuando la resolución de la pantalla sea pequeña
Cambiar orden de auxiliares dentro del menú y poner antes el 'Estado' que la 'Genética'
Poder crear auxiliares desde las pantallas de búsqueda asociadas
No se muestran los colores en el encabezado de los limites de referencia de auditorías
No vacía correctamente el estado en los límites de referencia de la pantalla genéticas
Incluir en listado 'Mi Histórico' el estado de la cerda y filtrar la información por estado de la cerda.
Versión: jueves, 14 de junio de 2018
No deja vaciar correctamente la información de granja y estado en los limites de referencia por genética
Gráficos de listados básicos mismas tamaños de letra y leyendas que en pantalla y tamaño proporcional a las dimensiones del folio de impresión.
Versión: viernes, 8 de junio de 2018
En importador de Excel si el usuario tiene hojas vacías genera error
Versión Beta de traducción al idioma francés
Visión 'Mi Histórico' con información en tiempo real
No se activa el Guardar/Cancelar al modificar detalles de genéticas
Error al realizar busquedas en los Grid con las cajas de ayuda
Barra de botones 'Favoritos' anclable y configurable a modo 'Barra de herramientas'
Agrupar la lista de mejoras por fecha en lugar de por fecha y hora
Pantalla de Panel de Inicio para granjero
Pantalla de Panel de Inicio para usuarios
Nuevo diseño de aplicación
No se posiciona el foco en la casilla de Login
No se muestra el menú 'Acerca'
Borrar representación de límites EGD y EMD de la pantalla la auditoria
Gráfico evolución por ciclo y estado. No ordena correctamente por estado
Gráfico de media que aparezca el rango medio siempre centrado
Incluir unidades en los ejes de los gráficos
Gráfico BoxPlot.La columna de distribución aceptable debe ir en escala de grises
Exportador Múltiple a Excel que renombre las columnas de límites según configuración elegida
Traducciones varias
Notificador de expiración de puesto vía email
Diferente orden de conceptos de búsqueda en buscador de auditorías
Visión 'Tiempo Real' en formato asistente
Mejoras visuales y de rendimiento
Informes Tiempo Real poder guardar filtros
Selector de hojas para importador de Excel
Versión: jueves, 17 de mayo de 2018
Implementación de derechos y control de acceso para 'Granjeros', 'Técnicos' y 'Nutricionistas'
Cuando solo se tiene derecho para consultar una granja que se cargue automaticamente al añadir una auditoría
Sistema de ayudas e información para gráficos
Presentación de patas de BoxPlot a misma altura que gráficos de barras
En BoxPlot EGD cambios en colores parametrizables
Revisión de titulos y encabezados de gráficos de la aplicación
Incluir la descripción del filtro en los informes
Representación del valor obtenido en el indicador de media (correcto, graso, etc.)
Informe básico incluir literal 'Commentaries and advises' para la información de comentario
Cambio de diseño, rangos, etc.del indicador de Coeficiente de variación
Interpretación de músculo (EGD) parametrizable (colores y descripciones de estados)
Redimensionamiento automática de las pantallas de ayuda y selección de datos
Validación de datos al navegar por los búscadores
Sistema de instalación poder recuperar un puesto desactivado por código de instalación
Poder guardar configuraciones del Exportador Múltiple a Excel
Generación de aplicaciones de tipo TEST
Informe básico incluir información del número de animales auditados y número de animales del lote
Pantalla de auditía incluir la información del número de animales
Desactivar funcionalidades de auditoría y genética cuando el buscador está vacío
Filtro por información de detalle en estadísticas de auditoría
Botón para plegar el árbol de seguridad
Presentación de Roles de seguridad en formato Pestaña
Exportación múltiple a Excel bloquea el cerrar la aplicación
Exportación de Grids a Excel poder guardar configuraciones
Sistema de notificación de fechas de expiración para los administradores de licencias
Indicador de media nuevos límites y gama de colores
Nuevos límites en gráfico de Coeficiente de variación
Control de duplicidad de puestos en sistema de instalación y ejecución
Gráficos barras referencias en forma de líneas finas horizontales de los porcentajes que se consideran correctos
Versión: lunes, 2 de abril de 2018
Errores menores, traducciones y optimización de aplicación
Presentación de posibles errores durante el proceso de instalación
Información de demografía ideal en pantalla de configuración
Nueva estadística de evolución por ciclo y estado de las cerdas
Estadísticas prefiltradas con información de auditoría actual
Nuevas columnas en selector de auditorías
Selector de Lotes para informe y búsquedas
Nueva informe y pantalla de auditoría básica
Eliminación de gráfico de estado corporal
Nuevo informe que muestra en un solo gráfico los valores correctos
EMD nuevo rango hasta Ideal
Exportador de múltiples auditorías a Excel
Botón para duplicar auditorías
Valor mínimo BoxPlot EGD estipulado a 5
Configuración de valores ideales para BoxPlot
Gráfico BoxPlot nueva barra con valores ideales
Cambio de cálculo de colores en indicador de media de auditorías
Cambio de cálculo de rangos en indicador de media de auditorías
Derechos de Acceso y Escritura en pantallas principales
Filtro de auditorías por Grupo de ciclo
Presentación de valores de la aplicación con un decimal
Versión: miércoles, 14 de marzo de 2018
Errores y mejoras de rendimiento
Errores en traducciones
NUEVO SISTEMA DE GESTIÓN DE LICENCIAS E INSTALACIONES EN: https://controlpanel.promatcloud.com
Posibilidad de limitar el acceso de un usuario a los datos de determinadas granjas
Versión: lunes, 26 de febrero de 2018
Nuevo diseño de pantalla de auditorías
Módulo de informes básico para auditoría
Versión: jueves, 22 de febrero de 2018
Errores y correcciones
Nuevo filtro de selección múltiple de auditorías en estadísticas
Característica para poder guardar y cargar filtros de consultas en estadísticas
Botón para duplicar una genética
NUEVO SISTEMA DE INSTALACIÓN EN ENTORNOS SIN DERECHOS DE ADMINISTRADOR
Mejoras varias
Asociar una genética a una granja
Revisión de número de decimales en auditoría
Característica para poder configurar límites por genética / estado en una granja determinada
Gestión de operadores
Indicador promedio
Indicador coeficiente variación
Versión: viernes, 29 de diciembre de 2017
Ayudas en la introducción de datos
Errores y mejoras de rendimientos
Buscador avanzado de auditorías
Limites por grupo de ciclo en lugar de por ciclo
Pantalla de gestión de roles
Estadística auditoría gráficos
Estadística Auditoría detalle";
    }
}
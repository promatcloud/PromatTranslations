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
                        "'{0}' deber�a ser una direcci�n de celda de Excel v�lida. Ej: A3",
                        "'{0}' deber�a ser una columna de Excel v�lida. Ej: AB",
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
                    "�Destacadas!", "Nueva presentaci�n con leyenda del gr�fico \"S�ntesis de reparto\"",
                    "Nueva presentaci�n gr�fica con iconos e im�genes", "Nuevo sistema de presentaci�n de filtros de informes",
                    "Revisi�n de visibilidad de gr�ficas de informe \"Basic Report\"", "Comentarios personalizados al generar informe \"OneShot / Un Vistazo\"",
                    "Comentarios personalizados al generar informe \"Mi Historico (Estado)\"",
                    "Comentarios personalizados al generar informe \"Mi Historico (Lote)\"", "Versi�n: jueves, 29 de noviembre de 2018",
                    "Scroll en pantalla auditor�as cuando no se cumple tama�o m�nimo de pantalla",
                    "Informe \"Un Vistazo\" mostrar el numero del valor medio en gr�fico por ciclo y estado",
                    "Identificar el n�mero de cerda en gr�fico \"datos por ciclo\" pasando el rat�n por encima",
                    "Versi�n: martes, 27 de noviembre de 2018", "Optimizaci�n en sistema de instalaci�n",
                    "Error al calcular rangos en informe \"Un Vistazo\"", "Versi�n: lunes, 26 de noviembre de 2018", "Revisi�n de traducciones",
                    "Mejoras de optimizaci�n y rendimiento", "La aplicaci�n permite modificar las cajas de solo lectura",
                    "Error la intentar sacar un informe que no tiene datos                                                                                                                                                                                                         ",
                    "Versi�n: viernes, 16 de noviembre de 2018", "Mostrar el usuario con el que se conect� en la barra de la aplicaci�n                                                                                                                                            ",
                    "Quitar hora de los informes y reducir tama�o de letra",
                    "Mostrar 5 columnas en las secciones de \"Informes\" y de \"Configuraci�n\" del \"Panel de inicio\"",
                    "Incluir informes \"OneShot / Un Vistazo\", \"Mi Historico (Lote)\" y \"Mi Historico (Estado)\" en el men� \"Informes\"",
                    "Error en c�lculo de perdidas en informe \"Mi Historico (Lote)\"", "Nuevo acceso a la captaci�n de ec�grafo en Panel de Inicio",
                    "Error al seleccionar un valor inexistente durante una b�squeda en las cajas de ayuda",
                    "Poder indicar en informe \"OneShot / Un vistazo\" si se muestra el comentario",
                    "Poder indicar en informe \"Mi Historico (Estado)\" si se muestra el comentario",
                    "Poder indicar en informe \"Mi Historico (Lote)\" si se muestra el comentario", "Pantalla de gesti�n de comentarios de informes",
                    "Borrado m�ltiple de l�enas en auditor�as ", "No mostrar la hora de la fecha de medici�n en los selectores de auditoria",
                    "Al cambiar la fecha de medici�n no se refresca en el buscador", "Mensaje informativo al asignar una imagen a una empresa",
                    "Error al borrar Usuarios",
                    "Exportaci�n y visualizaci�n aumentada de \"Indicador general de estado corporal\" e \"Indicador general de homogeneidad\"",
                    "Cambiar <= por s�mbolo combinado en informes                                                                                                                                      ",
                    "Cambiar literal \"m/m\" por \"mm\" en informes", "Error al guardar \"Mis Filtros\" en informe \"Mi Historico (Estado)\"",
                    "Error al guardar \"Mis Filtros\" en informe \"Mi Historico (Lote)\"",
                    "Error al guardar \"Mis Filtros\" en informe \"OneShot / Un Vistazo\"",
                    "Mostrar rango correcto centrado en \"Indicador general de estado corporal\"",
                    "Pantalla de errores en Excel que sea maximizable y redimensionable",
                    "Versi�n: jueves, 27 de septiembre de 2018", "Sistema de importaci�n Excel Ec�grafo (Beta)",
                    "Versi�n: mi�rcoles, 26 de septiembre de 2018", "Traspasar informaci�n de animales por lote de la granja a la auditor�a al crearla                                                                                                                                                                   ", "Calculadora de un s�lo lote llamar desde pantalla auditor�as                                                                                                                     ", "Traducciones, optimizaciones y errores menores", "Nuevo campo tama�o lote en Granja", "Calculadora simple para un s�lo lote", "Traducci�n opciones OneShot", "Versi�n: lunes, 24 de septiembre de 2018", "Migraci�n aplicaci�n a nuevo estandar Microsft FrameWork 4.7.2", "Validaci�n de datos en tiempo real (mientras se escriben)", "Error en traducci�n de validadores                                                                                                                                      ", "Mostrar pregunta al abondonar la aplicaci�n", "Captaci�n excel comenzar el fila 2 por defecto                                                                                                                                             ", "Error en c�lculo de media ponderada en l�mites con diferentes Grupos de Ciclo", "Error calculando limites para Multiparas en listados Condicion Corporal, Auditor�a gr�ficos, Comparativa auditor�a                                                                                                                                            ", "Error al pedir cambio de contrase�a en siguiente inicio de sesi�n", "Indicador BoxPlot con ayuda incrustada", "Informe de dispersi�n", "Optimizaci�n de velocidad listados", "Nuevo listado \"Mi Hist�rico(estado)\"", "Gr�fico de s�ntesis de reparto", "Ampliaci�n de demograf�a ideal a 7+", "Nueva maquetaci�n de informes de la aplicaci�n", "Nuevo dise�o listado \"B�sico\"", "Nuevo listado \"One Shot\"", "Nuevo listado \"Mi Hist�rico(lote)\"", "Selector de temas que solo muestre la vista preliminar de la pantalla", "Eliminar men� \"anchor status\" para que no desconfigure grids", "Pantalla de gen�ticas bloquear las columnas para que no se muevan", "Pantalla de Gen�ticas pasar a cursiva las columnas de solo lectura", "Soporte para pantallas con escalado DPI Windows", "Error en redimensionamiento de reports en pantallas con escalado Windows", "No muestra el cargar configuraci�n y guardar en Grids", "Nuevo dise�o de Panel de Inicio", "Logotipo de empresa en listados OneShot, Mi Hist�rico y B�sico", "Im�genes de logotipo configurable en empresa", "Versi�n: jueves, 28 de junio de 2018", "Implementaci�n y uso de certificaci�n de c�digo. ", "Errorres y mejoras de rendimiento/renderizaci�n de pantallas", "Nuevo orden de introducci�n de datos de auditor�a", "Buscador de auditor�as que se inicie oculto a menos que el usuario especifique otro comportamiento", "En el panel de inicio mostrar la barra de desplazamiento debajo cuando la resoluci�n de la pantalla sea peque�a", "Cambiar orden de auxiliares dentro del men� y poner antes el \"Estado\" que la \"Gen�tica\"", "Poder crear auxiliares desde las pantallas de b�squeda asociadas", "No se muestran los colores en el encabezado de los limites de referencia de auditor�as", "No vac�a correctamente el estado en los l�mites de referencia de la pantalla gen�ticas", "Incluir en listado \"Mi Hist�rico\" el estado de la cerda y filtrar la informaci�n por estado de la cerda.", "Versi�n: jueves, 14 de junio de 2018", "No deja vaciar correctamente la informaci�n de granja y estado en los limites de referencia por gen�tica", "Gr�ficos de listados b�sicos mismas tama�os de letra y leyendas que en pantalla y tama�o proporcional a las dimensiones del folio de impresi�n.", "Versi�n: viernes, 8 de junio de 2018", "En importador de Excel si el usuario tiene hojas vac�as genera error", "Versi�n Beta de traducci�n al idioma franc�s", "Visi�n \"Mi Hist�rico\" con informaci�n en tiempo real", "No se activa el Guardar/Cancelar al modificar detalles de gen�ticas", "Error al realizar busquedas en los Grid con las cajas de ayuda", "Barra de botones \"Favoritos\" anclable y configurable a modo \"Barra de herramientas\"", "Agrupar la lista de mejoras por fecha en lugar de por fecha y hora", "Pantalla de Panel de Inicio para granjero", "Pantalla de Panel de Inicio para usuarios", "Nuevo dise�o de aplicaci�n", "No se posiciona el foco en la casilla de Login", "No se muestra el men� \"Acerca\"", "Borrar representaci�n de l�mites EGD y EMD de la pantalla la auditoria", "Gr�fico evoluci�n por ciclo y estado. No ordena correctamente por estado", "Gr�fico de media que aparezca el rango medio siempre centrado", "Incluir unidades en los ejes de los gr�ficos", "Gr�fico BoxPlot. La columna de distribuci�n aceptable debe ir en escala de grises", "Exportador M�ltiple a Excel que renombre las columnas de l�mites seg�n configuraci�n elegida", "Traducciones varias", "Notificador de expiraci�n de puesto v�a email", "Diferente orden de conceptos de b�squeda en buscador de auditor�as", "Visi�n \"Tiempo Real\" en formato asistente", "Mejoras visuales y de rendimiento", "Informes Tiempo Real poder guardar filtros", "Selector de hojas para importador de Excel", "Versi�n: jueves, 17 de mayo de 2018", "Implementaci�n de derechos y control de acceso para \"Granjeros\", \"T�cnicos\" y \"Nutricionistas\"", "Cuando solo se tiene derecho para consultar una granja que se cargue automaticamente al a�adir una auditor�a", "Sistema de ayudas e informaci�n para gr�ficos", "Presentaci�n de patas de BoxPlot a misma altura que gr�ficos de barras", "En BoxPlot EGD cambios en colores parametrizables", "Revisi�n de titulos y encabezados de gr�ficos de la aplicaci�n", "Incluir la descripci�n del filtro en los informes", "Representaci�n del valor obtenido en el indicador de media (correcto, graso, etc.)", "Informe b�sico incluir literal \"Commentaries and advises\" para la informaci�n de comentario", "Cambio de dise�o, rangos, etc. del indicador de Coeficiente de variaci�n", "Interpretaci�n de m�sculo (EGD) parametrizable (colores y descripciones de estados)", "Redimensionamiento autom�tica de las pantallas de ayuda y selecci�n de datos", "Validaci�n de datos al navegar por los b�scadores", "Sistema de instalaci�n poder recuperar un puesto desactivado por c�digo de instalaci�n", "Poder guardar configuraciones del Exportador M�ltiple a Excel", "Generaci�n de aplicaciones de tipo TEST", "Informe b�sico incluir informaci�n del n�mero de animales auditados y n�mero de animales del lote", "Pantalla de audit�a incluir la informaci�n del n�mero de animales", "Desactivar funcionalidades de auditor�a y gen�tica cuando el buscador est� vac�o", "Filtro por informaci�n de detalle en estad�sticas de auditor�a", "Bot�n para plegar el �rbol de seguridad", "Presentaci�n de Roles de seguridad en formato Pesta�a", "Exportaci�n m�ltiple a Excel bloquea el cerrar la aplicaci�n", "Exportaci�n de Grids a Excel poder guardar configuraciones", "Sistema de notificaci�n de fechas de expiraci�n para los administradores de licencias", "Indicador de media nuevos l�mites y gama de colores", "Nuevos l�mites en gr�fico de Coeficiente de variaci�n", "Control de duplicidad de puestos en sistema de instalaci�n y ejecuci�n", "Gr�ficos barras referencias en forma de l�neas finas horizontales de los porcentajes que se consideran correctos                                               ", "Versi�n: lunes, 2 de abril de 2018", "Errores menores, traducciones y optimizaci�n de aplicaci�n", "Presentaci�n de posibles errores durante el proceso de instalaci�n", "Informaci�n de demograf�a ideal en pantalla de configuraci�n", "Nueva estad�stica de evoluci�n por ciclo y estado de las cerdas", "Estad�sticas prefiltradas con informaci�n de auditor�a actual", "Nuevas columnas en selector de auditor�as", "Selector de Lotes para informe y b�squedas", "Nueva informe y pantalla de auditor�a b�sica", "Eliminaci�n de gr�fico de estado corporal", "Nuevo informe que muestra en un solo gr�fico los valores correctos", "EMD nuevo rango hasta Ideal", "Exportador de m�ltiples auditor�as a Excel", "Bot�n para duplicar auditor�as", "Valor m�nimo BoxPlot EGD estipulado a 5", "Configuraci�n de valores ideales para BoxPlot", "Gr�fico BoxPlot nueva barra con valores ideales", "Cambio de c�lculo de colores en indicador de media de auditor�as", "Cambio de c�lculo de rangos en indicador de media de auditor�as", "Derechos de Acceso y Escritura en pantallas principales", "Filtro de auditor�as por Grupo de ciclo", "Presentaci�n de valores de la aplicaci�n con un decimal", "Versi�n: mi�rcoles, 14 de marzo de 2018", "Errores y mejoras de rendimiento", "Errores en traducciones", "NUEVO SISTEMA DE GESTI�N DE LICENCIAS E INSTALACIONES EN: https://controlpanel.promatcloud.com", "Posibilidad de limitar el acceso de un usuario a los datos de determinadas granjas", "Versi�n: lunes, 26 de febrero de 2018", "Nuevo dise�o de pantalla de auditor�as", "M�dulo de informes b�sico para auditor�a", "Versi�n: jueves, 22 de febrero de 2018", "Errores y correcciones", "Nuevo filtro de selecci�n m�ltiple de auditor�as en estad�sticas", "Caracter�stica para poder guardar y cargar filtros de consultas en estad�sticas", "Bot�n para duplicar una gen�tica", "NUEVO SISTEMA DE INSTALACI�N EN ENTORNOS SIN DERECHOS DE ADMINISTRADOR", "Mejoras varias", "Asociar una gen�tica a una granja", "Revisi�n de n�mero de decimales en auditor�a", "Caracter�stica para poder configurar l�mites por gen�tica / estado en una granja determinada", "Gesti�n de operadores", "Indicador promedio", "Indicador coeficiente variaci�n", "Versi�n: viernes, 29 de diciembre de 2017", "Ayudas en la introducci�n de datos", "Errores y mejoras de rendimientos", "Buscador avanzado de auditor�as", "Limites por grupo de ciclo en lugar de por ciclo", "Pantalla de gesti�n de roles", "Estad�stica auditor�a gr�ficos", "Estad�stica Auditor�a detalle"
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
                    return "Ol�";
                default:
                    return string.Empty;
            }
        }
        public static string GetWord2(string lang)
        {
            switch (lang)
            {
                case "es":
                    return "Adi�s";
                case "en":
                    return "Goodbye";
                case "fr":
                    return "Au revoir";
                case "it":
                    return "Arrivederci";
                case "pt":
                    return "At� logo";
                default:
                    return string.Empty;
            }
        }
        public static string GetParagraph(string lang)
        {
            switch (lang)
            {
                case "es":
                    return @"Esto es un peque�o p�rrafo.

Espero que vaya como un ca��n.

Cig�e�a peque�a.";
                case "en":
                    return @"This is a small paragraph.

I hope it goes like a cannon.

Small stork.";
                case "fr":
                    return @"C'est un petit paragraphe.

J'esp�re que �a va comme un canon.

Petite cigogne.";
                case "it":
                    return @"Questo � un piccolo paragrafo.

Spero che vada come un cannone.

Piccola cicogna.";
                case "pt":
                    return @"Este � um pequeno par�grafo.

Espero que v� como um canh�o.

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
                    return @"Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro.

Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro.

Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca.

As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas.

Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se.";
                case "en":
                    return @"And, seeing Don Quixote in that way, with signs of so much sadness, he said, Sabete, Sancho, who is not one man but another if he does nothing but another. All these drunkennessthats that happen to us are signs that Time must be calmed and things must be right for us; because it is not possible for evil or good to be durable, and from here it follows that, having long lasted evil, good is already near. So, you must not grieve for the misfortunes that happen to me, for you can't get part of them. And, seeing Don Quixote in that way, with signs of so much sadness, he said, Sabete, Sancho, who is not one man but another if he does nothing but another.

All these drunkennessthats that happen to us are signs that Time must be calmed and things must be right for us; because it is not possible for evil or good to be durable, and from here it follows that, having long lasted evil, good is already near. So, you must not grieve for the misfortunes that happen to me, for you can't get part of them. And, seeing Don Quixote in that way, with signs of so much sadness, he said, Sabete, Sancho, who is not one man but another if he does nothing but another.

All these drunkennessthats that happen to us are signs that Time must be calmed and things must be right for us; because it is not possible for evil or good to be durable, and from here it follows that, having long lasted evil, good is already near. So, you must not grieve for the misfortunes that happen to me, for you can't get part of them. And, seeing Don Quixote in that way, with signs of so much sadness, he said, Sabete, Sancho, who is not one man but another if he does nothing but another. All these drunkennessthats that happen to us are signs that Time must be calmed and things must be right for us; because it is not possible for evil or good to be durable, and from here it follows that, having long lasted evil, good is already near.

So, you must not grieve for the misfortunes that happen to me, for you can't get part of them. And, seeing Don Quixote in that way, with signs of so much sadness, he said, Sabete, Sancho, who is not one man but another if he does nothing but another. All these drunkennessthats that happen to us are signs that Time must be calmed and things must be right for us; because it is not possible for evil or good to be durable, and from here it follows that, having long lasted evil, good is already near. So, you must not grieve for the misfortunes that happen to me, for you can't get part of them.

And, seeing Don Quixote in that way, with signs of so much sadness, he said, Sabete, Sancho, who is not one man but another if he does nothing but another. All these drunkennessthats that happen to us are signs that Time must be calmed and things must be right for us; because it is not possible for evil or good to be durable, and from here it follows that, having long lasted evil, good is already near. So, you must not grieve for the misfortunes that happen to me, for you can't get part of them. And, seeing Don Quixote in that way, with signs of so much sadness, he said, Sabete, Sancho, who is not one man but another if he does nothing but another. All these drunkennessthats that happen to us are signs that Time must be calmed and things must be right for us; because it is not possible for evil or good to be durable, and from here it follows that, having long lasted evil, good is already near. So, you must not grieve for the misfortunes that happen to me, for you can't get part of them. And, seeing Don Quixote in that way, with signs of so much sadness, he said, Sabete, Sancho, who is not one man but another if he does nothing but another. All these drunkennessthats that happen to us are signs that Time must be calmed and things must be right for us; because it is not possible for evil or good to be durable, and from here it is.";
                case "fr":
                    return @"Et, voyant Don Quichotte de cette fa�on, avec des signes de tant de tristesse, il a dit, Sabete, Sancho, qui n'est pas un homme, mais un autre s'il ne fait rien, mais un autre. Toutes ces ivresse qui nous arrivent sont des signes que le temps doit �tre calm� et que les choses doivent �tre bonnes pour nous ; parce qu'il n'est pas possible pour le mal ou le bien d'�tre durable, et d'ici il s'ensuit que, apr�s avoir longtemps dur� le mal, le bien est d�j� proche. Donc, vous ne devez pas pleurer pour les malheurs qui m'arrivent, car vous ne pouvez pas en faire partie. Et, voyant Don Quichotte de cette fa�on, avec des signes de tant de tristesse, il a dit, Sabete, Sancho, qui n'est pas un homme, mais un autre s'il ne fait rien, mais un autre.

Toutes ces ivresse qui nous arrivent sont des signes que le temps doit �tre calm� et que les choses doivent �tre bonnes pour nous ; parce qu'il n'est pas possible pour le mal ou le bien d'�tre durable, et d'ici il s'ensuit que, apr�s avoir longtemps dur� le mal, le bien est d�j� proche. Donc, vous ne devez pas pleurer pour les malheurs qui m'arrivent, car vous ne pouvez pas en faire partie. Et, voyant Don Quichotte de cette fa�on, avec des signes de tant de tristesse, il a dit, Sabete, Sancho, qui n'est pas un homme, mais un autre s'il ne fait rien, mais un autre.

Toutes ces ivresse qui nous arrivent sont des signes que le temps doit �tre calm� et que les choses doivent �tre bonnes pour nous ; parce qu'il n'est pas possible pour le mal ou le bien d'�tre durable, et d'ici il s'ensuit que, apr�s avoir longtemps dur� le mal, le bien est d�j� proche. Donc, vous ne devez pas pleurer pour les malheurs qui m'arrivent, car vous ne pouvez pas en faire partie. Et, voyant Don Quichotte de cette fa�on, avec des signes de tant de tristesse, il a dit, Sabete, Sancho, qui n'est pas un homme, mais un autre s'il ne fait rien, mais un autre. Toutes ces ivresse qui nous arrivent sont des signes que le temps doit �tre calm� et que les choses doivent �tre bonnes pour nous ; parce qu'il n'est pas possible pour le mal ou le bien d'�tre durable, et d'ici il s'ensuit que, apr�s avoir longtemps dur� le mal, le bien est d�j� proche.

Donc, vous ne devez pas pleurer pour les malheurs qui m'arrivent, car vous ne pouvez pas en faire partie. Et, voyant Don Quichotte de cette fa�on, avec des signes de tant de tristesse, il a dit, Sabete, Sancho, qui n'est pas un homme, mais un autre s'il ne fait rien, mais un autre. Toutes ces ivresse qui nous arrivent sont des signes que le temps doit �tre calm� et que les choses doivent �tre bonnes pour nous ; parce qu'il n'est pas possible pour le mal ou le bien d'�tre durable, et d'ici il s'ensuit que, apr�s avoir longtemps dur� le mal, le bien est d�j� proche. Donc, vous ne devez pas pleurer pour les malheurs qui m'arrivent, car vous ne pouvez pas en faire partie.

Et, voyant Don Quichotte de cette fa�on, avec des signes de tant de tristesse, il a dit, Sabete, Sancho, qui n'est pas un homme, mais un autre s'il ne fait rien, mais un autre. Toutes ces ivresse qui nous arrivent sont des signes que le temps doit �tre calm� et que les choses doivent �tre bonnes pour nous ; parce qu'il n'est pas possible pour le mal ou le bien d'�tre durable, et d'ici il s'ensuit que, apr�s avoir longtemps dur� le mal, le bien est d�j� proche. Donc, vous ne devez pas pleurer pour les malheurs qui m'arrivent, car vous ne pouvez pas en faire partie. Et, voyant Don Quichotte de cette fa�on, avec des signes de tant de tristesse, il a dit, Sabete, Sancho, qui n'est pas un homme, mais un autre s'il ne fait rien, mais un autre. Toutes ces ivresse qui nous arrivent sont des signes que le temps doit �tre calm� et que les choses doivent �tre bonnes pour nous ; parce qu'il n'est pas possible pour le mal ou le bien d'�tre durable, et d'ici il s'ensuit que, apr�s avoir longtemps dur� le mal, le bien est d�j� proche. Donc, vous ne devez pas pleurer pour les malheurs qui m'arrivent, car vous ne pouvez pas en faire partie. Et, voyant Don Quichotte de cette fa�on, avec des signes de tant de tristesse, il a dit, Sabete, Sancho, qui n'est pas un homme, mais un autre s'il ne fait rien, mais un autre. Toutes ces ivresse qui nous arrivent sont des signes que le temps doit �tre calm� et que les choses doivent �tre bonnes pour nous ; parce qu'il n'est pas possible pour le mal ou le bien d'�tre durable, et d'ici il est.";
                case "it":
                    return @"E, vedendo Don Chisciotte in quel modo, con segni di tanta tristezza, disse, Sabete, Sancho, che non � un uomo ma un altro se non fa altro che un altro. Tutta questa ubriachezza che ci capita sono segni che il Tempo deve essere calmato e le cose devono essere giuste per noi; perch� non � possibile che il male o il bene siano durevoli, e da qui ne consegue che, avendo durato a lungo il male, il bene � gi� vicino. Quindi, non devi soffrire per le disgrazie che mi succedono, perch� non puoi farne parte. E, vedendo Don Chisciotte in quel modo, con segni di tanta tristezza, disse, Sabete, Sancho, che non � un uomo ma un altro se non fa altro che un altro.

Tutta questa ubriachezza che ci capita sono segni che il Tempo deve essere calmato e le cose devono essere giuste per noi; perch� non � possibile che il male o il bene siano durevoli, e da qui ne consegue che, avendo durato a lungo il male, il bene � gi� vicino. Quindi, non devi soffrire per le disgrazie che mi succedono, perch� non puoi farne parte. E, vedendo Don Chisciotte in quel modo, con segni di tanta tristezza, disse, Sabete, Sancho, che non � un uomo ma un altro se non fa altro che un altro.

Tutta questa ubriachezza che ci capita sono segni che il Tempo deve essere calmato e le cose devono essere giuste per noi; perch� non � possibile che il male o il bene siano durevoli, e da qui ne consegue che, avendo durato a lungo il male, il bene � gi� vicino. Quindi, non devi soffrire per le disgrazie che mi succedono, perch� non puoi farne parte. E, vedendo Don Chisciotte in quel modo, con segni di tanta tristezza, disse, Sabete, Sancho, che non � un uomo ma un altro se non fa altro che un altro. Tutta questa ubriachezza che ci capita sono segni che il Tempo deve essere calmato e le cose devono essere giuste per noi; perch� non � possibile che il male o il bene siano durevoli, e da qui ne consegue che, avendo durato a lungo il male, il bene � gi� vicino.

Quindi, non devi soffrire per le disgrazie che mi succedono, perch� non puoi farne parte. E, vedendo Don Chisciotte in quel modo, con segni di tanta tristezza, disse, Sabete, Sancho, che non � un uomo ma un altro se non fa altro che un altro. Tutta questa ubriachezza che ci capita sono segni che il Tempo deve essere calmato e le cose devono essere giuste per noi; perch� non � possibile che il male o il bene siano durevoli, e da qui ne consegue che, avendo durato a lungo il male, il bene � gi� vicino. Quindi, non devi soffrire per le disgrazie che mi succedono, perch� non puoi farne parte.

E, vedendo Don Chisciotte in quel modo, con segni di tanta tristezza, disse, Sabete, Sancho, che non � un uomo ma un altro se non fa altro che un altro. Tutta questa ubriachezza che ci capita sono segni che il Tempo deve essere calmato e le cose devono essere giuste per noi; perch� non � possibile che il male o il bene siano durevoli, e da qui ne consegue che, avendo durato a lungo il male, il bene � gi� vicino. Quindi, non devi soffrire per le disgrazie che mi succedono, perch� non puoi farne parte. E, vedendo Don Chisciotte in quel modo, con segni di tanta tristezza, disse, Sabete, Sancho, che non � un uomo ma un altro se non fa altro che un altro. Tutta questa ubriachezza che ci capita sono segni che il Tempo deve essere calmato e le cose devono essere giuste per noi; perch� non � possibile che il male o il bene siano durevoli, e da qui ne consegue che, avendo durato a lungo il male, il bene � gi� vicino. Quindi, non devi soffrire per le disgrazie che mi succedono, perch� non puoi farne parte. E, vedendo Don Chisciotte in quel modo, con segni di tanta tristezza, disse, Sabete, Sancho, che non � un uomo ma un altro se non fa altro che un altro. Tutta questa ubriachezza che ci capita sono segni che il Tempo deve essere calmato e le cose devono essere giuste per noi; perch� non � possibile che il male o il bene siano durevoli, e da qui lo �.";
                case "pt":
                    return @"E, vendo Dom Quixote dessa forma, com sinais de tanta tristeza, disse ele, Sabete, Sancho, que n�o � um s� homem sen�o outro se n�o fizer nada sen�o outro. Todos esses b�bados que acontecem conosco s�o sinais de que o tempo deve ser acalmado e as coisas devem ser certas para n�s; Porque n�o � poss�vel para o mal ou bom ser dur�vel, e a partir daqui, segue-se que, tendo durado muito mal, o bem j� est� perto. Ent�o, voc� n�o deve lamentar pelas infort�nios que acontecem comigo, pois voc� n�o pode obter parte deles. E, vendo Dom Quixote dessa forma, com sinais de tanta tristeza, disse ele, Sabete, Sancho, que n�o � um s� homem sen�o outro se n�o fizer nada sen�o outro.

Todos esses b�bados que acontecem conosco s�o sinais de que o tempo deve ser acalmado e as coisas devem ser certas para n�s; Porque n�o � poss�vel para o mal ou bom ser dur�vel, e a partir daqui, segue-se que, tendo durado muito mal, o bem j� est� perto. Ent�o, voc� n�o deve lamentar pelas infort�nios que acontecem comigo, pois voc� n�o pode obter parte deles. E, vendo Dom Quixote dessa forma, com sinais de tanta tristeza, disse ele, Sabete, Sancho, que n�o � um s� homem sen�o outro se n�o fizer nada sen�o outro.

Todos esses b�bados que acontecem conosco s�o sinais de que o tempo deve ser acalmado e as coisas devem ser certas para n�s; Porque n�o � poss�vel para o mal ou bom ser dur�vel, e a partir daqui, segue-se que, tendo durado muito mal, o bem j� est� perto. Ent�o, voc� n�o deve lamentar pelas infort�nios que acontecem comigo, pois voc� n�o pode obter parte deles. E, vendo Dom Quixote dessa forma, com sinais de tanta tristeza, disse ele, Sabete, Sancho, que n�o � um s� homem sen�o outro se n�o fizer nada sen�o outro. Todos esses b�bados que acontecem conosco s�o sinais de que o tempo deve ser acalmado e as coisas devem ser certas para n�s; Porque n�o � poss�vel para o mal ou bom ser dur�vel, e a partir daqui, segue-se que, tendo durado muito mal, o bem j� est� perto.

Ent�o, voc� n�o deve lamentar pelas infort�nios que acontecem comigo, pois voc� n�o pode obter parte deles. E, vendo Dom Quixote dessa forma, com sinais de tanta tristeza, disse ele, Sabete, Sancho, que n�o � um s� homem sen�o outro se n�o fizer nada sen�o outro. Todos esses b�bados que acontecem conosco s�o sinais de que o tempo deve ser acalmado e as coisas devem ser certas para n�s; Porque n�o � poss�vel para o mal ou bom ser dur�vel, e a partir daqui, segue-se que, tendo durado muito mal, o bem j� est� perto. Ent�o, voc� n�o deve lamentar pelas infort�nios que acontecem comigo, pois voc� n�o pode obter parte deles.

E, vendo Dom Quixote dessa forma, com sinais de tanta tristeza, disse ele, Sabete, Sancho, que n�o � um s� homem sen�o outro se n�o fizer nada sen�o outro. Todos esses b�bados que acontecem conosco s�o sinais de que o tempo deve ser acalmado e as coisas devem ser certas para n�s; Porque n�o � poss�vel para o mal ou bom ser dur�vel, e a partir daqui, segue-se que, tendo durado muito mal, o bem j� est� perto. Ent�o, voc� n�o deve lamentar pelas infort�nios que acontecem comigo, pois voc� n�o pode obter parte deles. E, vendo Dom Quixote dessa forma, com sinais de tanta tristeza, disse ele, Sabete, Sancho, que n�o � um s� homem sen�o outro se n�o fizer nada sen�o outro. Todos esses b�bados que acontecem conosco s�o sinais de que o tempo deve ser acalmado e as coisas devem ser certas para n�s; Porque n�o � poss�vel para o mal ou bom ser dur�vel, e a partir daqui, segue-se que, tendo durado muito mal, o bem j� est� perto. Ent�o, voc� n�o deve lamentar pelas infort�nios que acontecem comigo, pois voc� n�o pode obter parte deles. E, vendo Dom Quixote dessa forma, com sinais de tanta tristeza, disse ele, Sabete, Sancho, que n�o � um s� homem sen�o outro se n�o fizer nada sen�o outro. Todos esses b�bados que acontecem conosco s�o sinais de que o tempo deve ser acalmado e as coisas devem ser certas para n�s; Porque n�o � poss�vel para o mal ou bom ser dur�vel, e a partir daqui �.";
                default:
                    return string.Empty;
            }
        }

        public static string Get6093CharactersInsomeParagraphs(string lang)
        {
            switch (lang)
            {
                case "es":
                    return @"Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas.

Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas.

Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas.

Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas.

Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que";
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
                    return @"Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que, habiendo durado mucho el mal, el bien est� ya cerca. As� que, no debes congojarte por las desgracias que a m� me suceden, pues a ti no te cabe parte dellas. Y, vi�ndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: S�bete, Sancho, que no es un hombre m�s que otro si no hace m�s que otro. Todas estas borrascas que nos suceden son se�ales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aqu� se sigue que";
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
        public static string GetFarmingControlNovedades() => @"�Destacadas!
Nueva presentaci�n con leyenda del gr�fico 'S�ntesis de reparto'
Nueva presentaci�n gr�fica con iconos e im�genes
Nuevo sistema de presentaci�n de filtros de informes
Revisi�n de visibilidad de gr�ficas de informe 'Basic Report'
Comentarios personalizados al generar informe 'OneShot / Un Vistazo'
Comentarios personalizados al generar informe 'Mi Historico (Estado)'
Comentarios personalizados al generar informe 'Mi Historico (Lote)'
Versi�n: jueves, 29 de noviembre de 2018
Scroll en pantalla auditor�as cuando no se cumple tama�o m�nimo de pantalla
Informe 'Un Vistazo' mostrar el numero del valor medio en gr�fico por ciclo y estado
Identificar el n�mero de cerda en gr�fico 'datos por ciclo' pasando el rat�n por encima
Versi�n: martes, 27 de noviembre de 2018
Optimizaci�n en sistema de instalaci�n
Error al calcular rangos en informe 'Un Vistazo'
Versi�n: lunes, 26 de noviembre de 2018
Revisi�n de traducciones
Mejoras de optimizaci�n y rendimiento
La aplicaci�n permite modificar las cajas de solo lectura
Error la intentar sacar un informe que no tiene datos
Versi�n: viernes, 16 de noviembre de 2018
Mostrar el usuario con el que se conect� en la barra de la aplicaci�n
Quitar hora de los informes y reducir tama�o de letra
Mostrar 5 columnas en las secciones de 'Informes' y de 'Configuraci�n' del 'Panel de inicio'
Incluir informes 'OneShot / Un Vistazo', 'Mi Historico (Lote)' y 'Mi Historico (Estado)' en el men� 'Informes'
Error en c�lculo de perdidas en informe 'Mi Historico (Lote)'
Nuevo acceso a la captaci�n de ec�grafo en Panel de Inicio
Error al seleccionar un valor inexistente durante una b�squeda en las cajas de ayuda
Poder indicar en informe 'OneShot / Un vistazo' si se muestra el comentario
Poder indicar en informe 'Mi Historico (Estado)' si se muestra el comentario
Poder indicar en informe 'Mi Historico (Lote)' si se muestra el comentario
Pantalla de gesti�n de comentarios de informes
Borrado m�ltiple de l�enas en auditor�as
No mostrar la hora de la fecha de medici�n en los selectores de auditoria
Al cambiar la fecha de medici�n no se refresca en el buscador
Mensaje informativo al asignar una imagen a una empresa
Error al borrar Usuarios
Exportaci�n y visualizaci�n aumentada de 'Indicador general de estado corporal' e 'Indicador general de homogeneidad'
Cambiar <= por s�mbolo combinado en informes
Cambiar literal 'm/m' por 'mm' en informes
Error al guardar 'Mis Filtros' en informe 'Mi Historico (Estado)'
Error al guardar 'Mis Filtros' en informe 'Mi Historico (Lote)'
Error al guardar 'Mis Filtros' en informe 'OneShot / Un Vistazo'
Mostrar rango correcto centrado en 'Indicador general de estado corporal'
Pantalla de errores en Excel que sea maximizable y redimensionable
Versi�n: jueves, 27 de septiembre de 2018
Sistema de importaci�n Excel Ec�grafo(Beta)
Versi�n: mi�rcoles, 26 de septiembre de 2018
Traspasar informaci�n de animales por lote de la granja a la auditor�a al crearla
Calculadora de un s�lo lote llamar desde pantalla auditor�as
Traducciones, optimizaciones y errores menores
Nuevo campo tama�o lote en Granja
Calculadora simple para un s�lo lote
Traducci�n opciones OneShot
Versi�n: lunes, 24 de septiembre de 2018
Migraci�n aplicaci�n a nuevo estandar Microsft FrameWork 4.7.2
Validaci�n de datos en tiempo real(mientras se escriben)
Error en traducci�n de validadores
Mostrar pregunta al abondonar la aplicaci�n
Captaci�n excel comenzar el fila 2 por defecto
Error en c�lculo de media ponderada en l�mites con diferentes Grupos de Ciclo
Error calculando limites para Multiparas en listados Condicion Corporal, Auditor�a gr�ficos, Comparativa auditor�a
Error al pedir cambio de contrase�a en siguiente inicio de sesi�n
Indicador BoxPlot con ayuda incrustada
Informe de dispersi�n
Optimizaci�n de velocidad listados
Nuevo listado 'Mi Hist�rico(estado)'
Gr�fico de s�ntesis de reparto
Ampliaci�n de demograf�a ideal a 7+
Nueva maquetaci�n de informes de la aplicaci�n
Nuevo dise�o listado 'B�sico'
Nuevo listado 'One Shot'
Nuevo listado 'Mi Hist�rico(lote)'
Selector de temas que solo muestre la vista preliminar de la pantalla
Eliminar men� 'anchor status' para que no desconfigure grids
Pantalla de gen�ticas bloquear las columnas para que no se muevan
Pantalla de Gen�ticas pasar a cursiva las columnas de solo lectura
Soporte para pantallas con escalado DPI Windows
Error en redimensionamiento de reports en pantallas con escalado Windows
No muestra el cargar configuraci�n y guardar en Grids
Nuevo dise�o de Panel de Inicio
Logotipo de empresa en listados OneShot, Mi Hist�rico y B�sico
Im�genes de logotipo configurable en empresa
Versi�n: jueves, 28 de junio de 2018
Implementaci�n y uso de certificaci�n de c�digo.
Errorres y mejoras de rendimiento/renderizaci�n de pantallas
Nuevo orden de introducci�n de datos de auditor�a
Buscador de auditor�as que se inicie oculto a menos que el usuario especifique otro comportamiento
En el panel de inicio mostrar la barra de desplazamiento debajo cuando la resoluci�n de la pantalla sea peque�a
Cambiar orden de auxiliares dentro del men� y poner antes el 'Estado' que la 'Gen�tica'
Poder crear auxiliares desde las pantallas de b�squeda asociadas
No se muestran los colores en el encabezado de los limites de referencia de auditor�as
No vac�a correctamente el estado en los l�mites de referencia de la pantalla gen�ticas
Incluir en listado 'Mi Hist�rico' el estado de la cerda y filtrar la informaci�n por estado de la cerda.
Versi�n: jueves, 14 de junio de 2018
No deja vaciar correctamente la informaci�n de granja y estado en los limites de referencia por gen�tica
Gr�ficos de listados b�sicos mismas tama�os de letra y leyendas que en pantalla y tama�o proporcional a las dimensiones del folio de impresi�n.
Versi�n: viernes, 8 de junio de 2018
En importador de Excel si el usuario tiene hojas vac�as genera error
Versi�n Beta de traducci�n al idioma franc�s
Visi�n 'Mi Hist�rico' con informaci�n en tiempo real
No se activa el Guardar/Cancelar al modificar detalles de gen�ticas
Error al realizar busquedas en los Grid con las cajas de ayuda
Barra de botones 'Favoritos' anclable y configurable a modo 'Barra de herramientas'
Agrupar la lista de mejoras por fecha en lugar de por fecha y hora
Pantalla de Panel de Inicio para granjero
Pantalla de Panel de Inicio para usuarios
Nuevo dise�o de aplicaci�n
No se posiciona el foco en la casilla de Login
No se muestra el men� 'Acerca'
Borrar representaci�n de l�mites EGD y EMD de la pantalla la auditoria
Gr�fico evoluci�n por ciclo y estado. No ordena correctamente por estado
Gr�fico de media que aparezca el rango medio siempre centrado
Incluir unidades en los ejes de los gr�ficos
Gr�fico BoxPlot.La columna de distribuci�n aceptable debe ir en escala de grises
Exportador M�ltiple a Excel que renombre las columnas de l�mites seg�n configuraci�n elegida
Traducciones varias
Notificador de expiraci�n de puesto v�a email
Diferente orden de conceptos de b�squeda en buscador de auditor�as
Visi�n 'Tiempo Real' en formato asistente
Mejoras visuales y de rendimiento
Informes Tiempo Real poder guardar filtros
Selector de hojas para importador de Excel
Versi�n: jueves, 17 de mayo de 2018
Implementaci�n de derechos y control de acceso para 'Granjeros', 'T�cnicos' y 'Nutricionistas'
Cuando solo se tiene derecho para consultar una granja que se cargue automaticamente al a�adir una auditor�a
Sistema de ayudas e informaci�n para gr�ficos
Presentaci�n de patas de BoxPlot a misma altura que gr�ficos de barras
En BoxPlot EGD cambios en colores parametrizables
Revisi�n de titulos y encabezados de gr�ficos de la aplicaci�n
Incluir la descripci�n del filtro en los informes
Representaci�n del valor obtenido en el indicador de media (correcto, graso, etc.)
Informe b�sico incluir literal 'Commentaries and advises' para la informaci�n de comentario
Cambio de dise�o, rangos, etc.del indicador de Coeficiente de variaci�n
Interpretaci�n de m�sculo (EGD) parametrizable (colores y descripciones de estados)
Redimensionamiento autom�tica de las pantallas de ayuda y selecci�n de datos
Validaci�n de datos al navegar por los b�scadores
Sistema de instalaci�n poder recuperar un puesto desactivado por c�digo de instalaci�n
Poder guardar configuraciones del Exportador M�ltiple a Excel
Generaci�n de aplicaciones de tipo TEST
Informe b�sico incluir informaci�n del n�mero de animales auditados y n�mero de animales del lote
Pantalla de audit�a incluir la informaci�n del n�mero de animales
Desactivar funcionalidades de auditor�a y gen�tica cuando el buscador est� vac�o
Filtro por informaci�n de detalle en estad�sticas de auditor�a
Bot�n para plegar el �rbol de seguridad
Presentaci�n de Roles de seguridad en formato Pesta�a
Exportaci�n m�ltiple a Excel bloquea el cerrar la aplicaci�n
Exportaci�n de Grids a Excel poder guardar configuraciones
Sistema de notificaci�n de fechas de expiraci�n para los administradores de licencias
Indicador de media nuevos l�mites y gama de colores
Nuevos l�mites en gr�fico de Coeficiente de variaci�n
Control de duplicidad de puestos en sistema de instalaci�n y ejecuci�n
Gr�ficos barras referencias en forma de l�neas finas horizontales de los porcentajes que se consideran correctos
Versi�n: lunes, 2 de abril de 2018
Errores menores, traducciones y optimizaci�n de aplicaci�n
Presentaci�n de posibles errores durante el proceso de instalaci�n
Informaci�n de demograf�a ideal en pantalla de configuraci�n
Nueva estad�stica de evoluci�n por ciclo y estado de las cerdas
Estad�sticas prefiltradas con informaci�n de auditor�a actual
Nuevas columnas en selector de auditor�as
Selector de Lotes para informe y b�squedas
Nueva informe y pantalla de auditor�a b�sica
Eliminaci�n de gr�fico de estado corporal
Nuevo informe que muestra en un solo gr�fico los valores correctos
EMD nuevo rango hasta Ideal
Exportador de m�ltiples auditor�as a Excel
Bot�n para duplicar auditor�as
Valor m�nimo BoxPlot EGD estipulado a 5
Configuraci�n de valores ideales para BoxPlot
Gr�fico BoxPlot nueva barra con valores ideales
Cambio de c�lculo de colores en indicador de media de auditor�as
Cambio de c�lculo de rangos en indicador de media de auditor�as
Derechos de Acceso y Escritura en pantallas principales
Filtro de auditor�as por Grupo de ciclo
Presentaci�n de valores de la aplicaci�n con un decimal
Versi�n: mi�rcoles, 14 de marzo de 2018
Errores y mejoras de rendimiento
Errores en traducciones
NUEVO SISTEMA DE GESTI�N DE LICENCIAS E INSTALACIONES EN: https://controlpanel.promatcloud.com
Posibilidad de limitar el acceso de un usuario a los datos de determinadas granjas
Versi�n: lunes, 26 de febrero de 2018
Nuevo dise�o de pantalla de auditor�as
M�dulo de informes b�sico para auditor�a
Versi�n: jueves, 22 de febrero de 2018
Errores y correcciones
Nuevo filtro de selecci�n m�ltiple de auditor�as en estad�sticas
Caracter�stica para poder guardar y cargar filtros de consultas en estad�sticas
Bot�n para duplicar una gen�tica
NUEVO SISTEMA DE INSTALACI�N EN ENTORNOS SIN DERECHOS DE ADMINISTRADOR
Mejoras varias
Asociar una gen�tica a una granja
Revisi�n de n�mero de decimales en auditor�a
Caracter�stica para poder configurar l�mites por gen�tica / estado en una granja determinada
Gesti�n de operadores
Indicador promedio
Indicador coeficiente variaci�n
Versi�n: viernes, 29 de diciembre de 2017
Ayudas en la introducci�n de datos
Errores y mejoras de rendimientos
Buscador avanzado de auditor�as
Limites por grupo de ciclo en lugar de por ciclo
Pantalla de gesti�n de roles
Estad�stica auditor�a gr�ficos
Estad�stica Auditor�a detalle";
    }
}
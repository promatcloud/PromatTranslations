using System.Collections.Generic;
using PromatTranslations.Models;

namespace PromatTranslations.Tests.Unit
{
    public static class Repository
    {
        public static List<string> GetNewsList() => new List<string>
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
        public static List<List<TranslationInfo>> GetNewsRawTranslation() => Newtonsoft.Json.JsonConvert.DeserializeObject<List<List<TranslationInfo>>>("[[{\"Language\":\"en\",\"Text\":\"*1*Highlights!\\r\\n*2*New presentation with chart legend \\\"Split Synthesis\\\"\\r\\n*3*New graphic presentation with icons and images\\r\\n*4*New report filter reporting system\\r\\n*5*Review of report graph visibility \\\"Basic Report\\\"\\r\\n*6*Custom Comments When Generating Report \\\"OneShot / One View\\\"\\r\\n*7*Custom comments when generating report \\\"My Historic (State)\\\"\\r\\n*8*Custom Comments When Generating Report \\\"My Historic (Lot)\\\"\\r\\n*9*Version: Thursday, November 29, 2018\\r\\n*10*Scroll on screen audits when minimum screen size is not met\\r\\n*11*One-way View Report show the number of the average value on graph by cycle and status\\r\\n*12*Identify the number of sow in \\\"data per cycle\\\" chart hovering over\\r\\n*13*Version: Tuesday, November 27, 2018\\r\\n*14*Optimization in installation system\\r\\n*15*Error calculating ranges in \\\"One View\\\" report\\r\\n*16*Version: Monday, November 26, 2018\\r\\n*17*Translation review\\r\\n*18*Optimization and performance improvements\\r\\n*19*The application allows you to modify the read-only boxes\\r\\n*20*Error trying to pull a report that has no data\\r\\n*21*Version: Friday, November 16, 2018\\r\\n*22*Show the user you connected with in the app bar\\r\\n*23*Remove time from reports and reduce font size\\r\\n*24*Show 5 columns in the \\\"Reports\\\" and \\\"Settings\\\" sections of the \\\"Start Panel\\\"\\r\\n*25*Include reports \\\"OneShot / One View\\\", \\\"My Historic (Lot)\\\" and \\\"My Historic (State)\\\" in the menu \\\"Reports\\\"\\r\\n*26*Error in calculation of losses in report \\\"My Historic (Lot)\\\"\\r\\n*27*New access to ultrasound capture on Home Panel\\r\\n*28*Error selecting a non-existent value during a search in help boxes\\r\\n*29*Be able to indicate \\\"OneShot / A Glance\\\" report if the comment is displayed\\r\\n*30*Be able to indicate in report \\\"My Historic (State)\\\" if the comment is shown\\r\\n*31*Be able to indicate in \\\"My Historic (Lot)\\\" report if the comment is shown\\r\\n*32*Report comment management screen\\r\\n*33*Multiple deletion of line in audits\\r\\n*34*Do not show the measurement date time in the auditory selectors\\r\\n*35*Changing the measurement date does not refresh in the search engine\\r\\n*36*Informational message when assigning an image to a company\\r\\n*37*Error deleting Users\\r\\n*38*Export and augmented display of \\\"General Body Status Indicator\\\" and \\\"General Homogeneity Indicator\\\"\\r\\n*39*Change <' by combined symbol in reports\\r\\n*40*Change literal \\\"m/m\\\" to \\\"mm\\\" in reports\\r\\n*41*Error saving \\\"My Filters\\\" in \\\"My Historic (State)\\\"\\r\\n*42*Error saving \\\"My Filters\\\" in \\\"My Historic (Lot)\\\"\\r\\n*43*Error saving \\\"My Filters\\\" in report \\\"OneShot / One View\\\"\\r\\n*44*Show correct range centered on \\\"General Body Status Indicator\\\"\\r\\n*45*Error screen in Excel that is maximizable and resizable\\r\\n*46*Version: Thursday, September 27, 2018\\r\\n*47*Excel Echograph Import System (Beta)\\r\\n*48*Version: Wednesday, September 26, 2018\\r\\n*49*Transfer animal information per farm lot to the audit when it is created\\r\\n*50*Single Batch Calculator Call From Screen Audits\\r\\n*51*Translations, optimizations and minor errors\\r\\n*52*New batch size field in Farm\\r\\n*53*Simple single-lot calculator\\r\\n*54*Translation OneShot Options\\r\\n*55*Version: Monday, September 24, 2018\\r\\n*56*Migration application to new standard Microsft FrameWork 4.7.2\\r\\n*57*Real-time data validation (while typing)\\r\\n*58*Error in validator translation\\r\\n*59*Show question when you pay the app\\r\\n*60*Capture excel start row 2 by default\\r\\n*61*Error in weighted average calculation in limits with different Cycle Groups\\r\\n*62*Error calculating limits for Multiparas in Body Condition, Graphic Audit, Comparative Audit\\r\\n*63*Error requesting password change at next login\\r\\n*64*BoxPlot indicator with embedded help\\r\\n*65*Scatter Report\\r\\n*66*Speed Optimization listed\\r\\n*67*New listing \\\"My Historical(status)\\\"\\r\\n*68*Share synthesis graph\\r\\n*69*Ideal demography magnification to 7+\\r\\n*70*New app report layout\\r\\n*71*New design listed \\\"Basic\\\"\\r\\n*72*New listing \\\"One Shot\\\"\\r\\n*73*New listing \\\"My History(lot)\\\"\\r\\n*74*Theme Selector that only shows the screen preview\\r\\n*75*Remove \\\"anchor status\\\" menu so you don't unconfigure grids\\r\\n*76*Genetics screen lock columns so they don't move\\r\\n*77*Screen of Genetics go to italicize slashes the read-only columns\\r\\n*78*Support for Windows DPI scaled screens\\r\\n*79*Error in resizing reports on Windows scaled screens\\r\\n*80*Does not show load configuration and save to Grids\\r\\n*81*New Home Panel Design\\r\\n*82*Company logo in OneShot, My Historical and Basic listings\"}],[{\"Language\":\"en\",\"Text\":\"*83*Enterprise configurable logo images\\r\\n*84*Version: Thursday, June 28, 2018\\r\\n*85*Implementation and use of code certification.\\r\\n*86*Errors and performance/screen rendering improvements\\r\\n*87*New order for the entry of audit data\\r\\n*88*Audit Finder that starts hidden unless the user specifies other behavior\\r\\n*89*On the home panel show the scroll bar below when the screen resolution is small\\r\\n*90*Change order of auxiliaries within the menu and put before the \\\"Status\\\" than the \\\"Genetics\\\"\\r\\n*91*Being able to create auxiliaries from the associated search screens\\r\\n*92*Colors are not displayed in the audit reference limits header\\r\\n*93*Does not properly empty the status at the genetic screen reference limits\\r\\n*94*Include in list \\\"My Historical\\\" the status of the sow and filter the information by sow status.\\r\\n*95*Version: Thursday, June 14, 2018\\r\\n*96*Does not allow farm and state information to be properly emptied into referral limits by genetics\\r\\n*97*Basic list charts same font sizes and captions as on screen and size proportional to print folio dimensions.\\r\\n*98*Version: Friday, June 8, 2018\\r\\n*99*In Excel importer if user has empty sheets generates error\\r\\n*100*Beta version of French language translation\\r\\n*101*View \\\"My Historical\\\" with real-time information\\r\\n*102*Save/Cancel is not activated when modifying genetic details\\r\\n*103*Failed to search Grids with help boxes\\r\\n*104*\\\"Favorites\\\" button bar that can be pinned and configurable to \\\"Toolbar\\\"\\r\\n*105*Group the list of improvements by date instead of by date and time\\r\\n*106*Farmer Home Panel Screen\\r\\n*107*Home Panel Screen for Users\\r\\n*108*New application design\\r\\n*109*Focus is not positioned in Login box\\r\\n*110*The \\\"About\\\" menu is not displayed\\r\\n*111*Clear EGD and EMD boundary representation of the screen auditing\\r\\n*112*Evolution chart by cycle and status. Doesn't sort correctly by state\\r\\n*113*Average chart showing the always centered midrange\\r\\n*114*Include units in chart axes\\r\\n*115*BoxPlot chart. The acceptable distribution column must be grayscale\\r\\n*116*Multiple exporter to Excel that renames boundary columns according to chosen configuration\\r\\n*117*Miscellaneous translations\\r\\n*118*Post expiration notifier via email\\r\\n*119*Different order of search concepts in audit search engine\\r\\n*120*Real Time Vision in assistant format\\r\\n*121*Visual and performance improvements\\r\\n*122*Real Time Reports being able to save filters\\r\\n*123*Excel Importer Sheet Selector\\r\\n*124*Version: Thursday, May 17, 2018\\r\\n*125*Implementation of rights and access control for \\\"Farmers\\\", \\\"Technical\\\" and \\\"Nutritionists\\\"\\r\\n*126*When you are only entitled to consult a farm that loads automatically when you add an audit\\r\\n*127*Graphics Help and Information System\\r\\n*128*Presentation of BoxPlot legs at the same height as bar charts\\r\\n*129*In BoxPlot EGD changes in parameterizable colors\\r\\n*130*Review of app titles and graphic headers\\r\\n*131*Include filter description in reports\\r\\n*132*Representation of the value obtained in the mean indicator (correct, fat, etc.)\\r\\n*133*Basic report include literal \\\"Commentaries and advises\\\" for comment information\\r\\n*134*Change of design, ranges, etc. of the Coefficient of Variation indicator\\r\\n*135*Parameterizable muscle interpretation (EGD) (colors and status descriptions)\\r\\n*136*Automatic resizing of help screens and data selection\\r\\n*137*Data validation when browsing the searchers\\r\\n*138*Installation system being able to recover a deactivated position by installation code\\r\\n*139*To be able to save Multiple Exporter settings to Excel\\r\\n*140*Generation of TEST-type applications\\r\\n*141*Basic report include information on the number of animals audited and number of animals in the lot\\r\\n*142*Audit screen include animal number information\\r\\n*143*Disable auditing and genetics features when the search engine is empty\\r\\n*144*Filter for detail information in audit statistics\\r\\n*145*Button to fold the safety tree\\r\\n*146*Presentation of Security Roles in Tab Format\\r\\n*147*Multiple export to Excel blocks closing the app\\r\\n*148*Export grids to Excel to be able to save settings\\r\\n*149*Expiration date notification system for license managers\\r\\n*150*New Limits and Color Range Average Indicator\\r\\n*151*New limits on The Coefficient of Variation chart\\r\\n*152*Control of duplication of positions in installation and execution system\"}],[{\"Language\":\"en\",\"Text\":\"*153*Reference bar charts in the form of horizontal thin lines of percentages that are considered correct\\r\\n*154*Version: Monday, April 2, 2018\\r\\n*155*Minor errors, translations and application optimization\\r\\n*156*Presentation of possible errors during the installation process\\r\\n*157*Ideal demographic information on configuration screen\\r\\n*158*New statistics of evolution by cycle and status of bristles\\r\\n*159*Pre-filtered statistics with current audit information\\r\\n*160*New columns in audit selector\\r\\n*161*Batch Selector for Report and Searches\\r\\n*162*New report and basic audit screen\\r\\n*163*Removing body status chart\\r\\n*164*New report that shows the correct values on a single chart\\r\\n*165*EMD new range to Ideal\\r\\n*166*Multi-audit exporter to Excel\\r\\n*167*Button to duplicate audits\\r\\n*168*Minimum BoxPlot EGD value stipulated at 5\\r\\n*169*Setting ideal values for BoxPlot\\r\\n*170*BoxPlot chart new bar with ideal values\\r\\n*171*Change of color calculation in average audit indicator\\r\\n*172*Change of range calculation in average audit indicator\\r\\n*173*Access and Write Rights on Home Screens\\r\\n*174*Audit filter by Cycle Group\\r\\n*175*Presentation of application values with a decimal\\r\\n*176*Version: Wednesday, March 14, 2018\\r\\n*177*Errors and performance improvements\\r\\n*178*Errors in translations\\r\\n*179*NEW LICENSE MANAGEMENT SYSTEM AND INSTALLATIONS IN: https://controlpanel.promatcloud.com\\r\\n*180*Possibility to limit a user's access to data for certain farms\\r\\n*181*Version: Monday, February 26, 2018\\r\\n*182*New audit screen design\\r\\n*183*Basic audit reporting module\\r\\n*184*Version: Thursday, February 22, 2018\\r\\n*185*Errors and fixes\\r\\n*186*New multiple audit selection filter in statistics\\r\\n*187*Feature to save and load query filters in statistics\\r\\n*188*Button to duplicate a genetics\\r\\n*189*NEW INSTALLATION SYSTEM IN ENVIRONMENTS WITHOUT ADMINISTRATOR RIGHTS\\r\\n*190*Several improvements\\r\\n*191*Associate a genetics with a farm\\r\\n*192*Review of number of decimal places in audit\\r\\n*193*Feature to be able to set limits by genetics/state on a given farm\\r\\n*194*Operator management\\r\\n*195*Average indicator\\r\\n*196*Indicator coefficient variation\\r\\n*197*Version: Friday, December 29, 2017\\r\\n*198*Data entry aids\\r\\n*199*Errors and performance improvements\\r\\n*200*Advanced Audit Finder\\r\\n*201*Limits per cycle group instead of per cycle\\r\\n*202*Role Management Screen\\r\\n*203*Statistics audit graphs\\r\\n*204*Detail Audit Statistics\"}]]");
    }
}
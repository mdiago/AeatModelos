﻿/*
    Este archivo forma parte del proyecto AeatModelos(R).
    Copyright (c) 2020 Irene Solutions SL
    Autores: Manuel Diago García, Juan Bautista Garcia Traver.

    Este programa es software libre; lo puede distribuir y/o modificar
    según los terminos de la licencia GNU Affero General Public License
    versión 3 según su redacción de la Free Software Foundation con la
    siguiente condición añadida en la sección 15 según se establece en
    la sección 7(a):

    PARA CUALQUIER PARTE DEL CÓGIO PROPIEDAD DE IRENE SOLUTIONS. IRENE 
    SOLUTIONS NO SE HACE RESPONSABLE DE LA VULNERACIÓN DE DERECHOS 
    DE TERCEROS.

    Este programa se distribuye con la esperanza de que sea útil, pero
    SIN GARANTÍA DE NINGÚN TIPO; ni siquiera la derivada de un acuerdo
    comercial o utilización para un propósito particular.
   
    Para más información puede consultar la licencia GNU Affero General
    Public http://www.gnu.org/licenses o escribir a la Free Software 
    Foundation, Inc. , 51 Franklin Street, Fifth Floor,
    Boston, MA, 02110-1301 USA, o descargarla en la siguiente URL:
        http://www.irenesolutions.com/terms-of-use.pdf 

    Las interfaces de usuario con versiones del código fuente del presente 
    proyecto, modificado o no, o código de objeto del mismo, deben incluir
    de manera visible los correspondientes avisos legales exigidos en la
    sección 5 de la licencia GNU Affero General Public.
    
    Puede evitar el cumplimiento de lo establecido 
    anteriormente comprando una licencia comercial. 
    La compra de una licencia comercial es obligatoria
    desde el momento en que usted desarrolle software comercial incluyendo
    funcionalidades de AeatModelos sin la publicación del código fuente
    de sus propias aplicaciones.
    Estas actividades incluyen: La oferta de servicios de pago mediante
    aplicaciones web de cualquier tipo que incluyan la funcionalidad
    de AeatModelos.
    
    Para más información, contacte con la dirección: info@irenesolutions.com    
 */

using System.Collections.Generic;

namespace AeatModelos.Mod111e16v18
{

    /// <summary>
    /// Descripciones de campos.
    /// </summary>
    public class Txt
    {

        #region Propiedades Públicas Estáticas

        /// <summary>
        /// Diccionario con las descripciones de campo
        /// según clave (página.numcampo).
        /// </summary>
        public static Dictionary<string, string> Den = new Dictionary<string, string>() {
            {"000.001", "Constante."},
            {"000.002", "Modelo"},
            {"000.003", "Constante"},
            {"000.004", "Ejercicio de devengo (EEEE)"},
            {"000.005", "Período. (PP)"},
            {"000.006", "Constante"},
            {"000.007", "Constante"},
            {"000.008", "Reservado para la Administración. Rellenar con blancos"},
            {"000.009", "Versión del Programa (Nota 1)"},
            {"000.010", "Reservado para la Administración. Rellenar con blancos"},
            {"000.011", "NIF Empresa Desarrollo (Nota 1)"},
            {"000.012", "Reservado para la Administración. Rellenar con blancos"},
            {"000.013", "Constante"},
            {"000.015", "Constante. </T+ modelo+discriminante+Ejercicio+periodo+Tipo+>"},
            {"000.016", "Fin de Registro. Constante CRLF( Hexadecimal 0D0A, Decimal 1310)"},
            {"P01.001", "Inicio del identificador de modelo y página"},
            {"P01.002", "Modelo"},
            {"P01.003", "Página"},
            {"P01.004", "Fin de identificador de modelo"},
            {"P01.005", "Indicador de página complementaria"},
            {"P01.006", "Tipo de declaración"},
            {"P01.007", "Identificación. Sujeto pasivo. NIF"},
            {"P01.008", "Identificación. Sujeto pasivo. Denominación o Apellidos"},
            {"P01.009", "Identificación. Sujeto pasivo. Nombre"},
            {"P01.010", "Identificación. Ejercicio"},
            {"P01.011", "Identificación. Periodo"},
            {"P01.012", "Rendim. del trabajo - Rendimientos dinerarios - Nº de perceptores"},
            {"P01.013", "Rendim. del trabajo - Rendimientos dinerarios - Importe percepciones"},
            {"P01.014", "Rendim. del trabajo - Rendimientos dinerarios - Importe retenciones"},
            {"P01.015", "Rendim. del trabajo - Rendimientos en especie- Nº de perceptores"},
            {"P01.016", "Rendim. del trabajo - Rendimientos en especie- Valor percepciones en especie"},
            {"P01.017", "Rendim. del trabajo - Rendimientos en especie- Importe ingresos a cuenta"},
            {"P01.018", "Rendim. actividades económicas - Rendimientos dinerarios -Nº de perceptores"},
            {"P01.019", "Rendim. actividades económicas - Rendimientos dinerarios -Importe percepciones"},
            {"P01.020", "Rendim. actividades económicas - Rendimientos dinerarios -Importe retenciones"},
            {"P01.021", "Rendim. actividades económicas - Rendimientos en especie -Nº de perceptores"},
            {"P01.022", "Rendim. actividades económicas - Rendimientos en especie-Valor percepciones en especie"},
            {"P01.023", "Rendim. actividades económicas - Rendimientos en especie- Importe de los ingresos a cuenta"},
            {"P01.024", "Premios- Premios dinerarios - Nº  de perceptores"},
            {"P01.025", "Premios - Premios dinerarios - Importe de las percepciones"},
            {"P01.026", "Premios - Premios dinerarios - Importe de las retenciones"},
            {"P01.027", "Premios - Premios en especie - Nº de perceptores"},
            {"P01.028", "Premios - Premios en especie - Valor percepciones en especie"},
            {"P01.029", "Premios - Premios en especie - Importe de los ingresos a cuenta"},
            {"P01.030", "Ganancias patrim. Aprovecham. Forestales - Percep. dinerarias - Nº perceptores"},
            {"P01.031", "Ganancias patrim. Aprovecham. Forestales - Percep. dinerarias - Importe percepciones"},
            {"P01.032", "Ganancias patrim. Aprovecham. Forestales - Percep. dinerarias - Importe retenciones"},
            {"P01.033", "Ganancias patrim. Aprovecham. Forestales - Percep. en especie - Nº perceptores"},
            {"P01.034", "Ganancias patrim. Aprovecham. Forestales - Percep. en especie - Importe percepciones"},
            {"P01.035", "Ganancias patrim. Aprovecham. Forestales - Percep. en especie - Importe ingresos a cuenta"},
            {"P01.036", "Contraprest. cesión dchos. imagen - Nº de perceptores -"},
            {"P01.037", "Contraprest. cesión dchos. imagen - Contraprestaciones satisfechas"},
            {"P01.038", "Contraprest. cesión dchos. imagen - Importe de los ingresos a cuenta"},
            {"P01.039", "Total liquidación - Suma retenciones e ingresos a cuenta"},
            {"P01.040", "Total liquidación - Resultado de anteriores declaraciones"},
            {"P01.041", "Total liquidación - Resultado a ingresar"},
            {"P01.042", "Declaración complementaria"},
            {"P01.043", "Número de justificante de la declaración anterior"},
            {"P01.044", "Reservado. Administración presentando declaración de Colegio Concertado (CC)"},
            {"P01.045", "Domiciliación - IBAN"},
            {"P01.046", "Reservado para la Administración"},
            {"P01.047", "Reservado para el sello electrónico de la AEAT"},
            {"P01.048", "Indicador de fin de registro"}
        };

        #endregion

    }
}

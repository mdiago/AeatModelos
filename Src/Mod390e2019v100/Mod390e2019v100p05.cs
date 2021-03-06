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

namespace AeatModelos.Mod390e2019v100
{
    /// <summary>
    /// Página 5 modelo 390.
    /// </summary>
    public class Mod390e2019v100p05 : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod390e2019v100p05(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "005";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {

                {++c, new RegistroCampo(5,    1,     2,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null,                  "<T"        )}, //001
                {++c, new RegistroCampo(5,    3,     3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null,                  390,    0   )}, //002
                {++c, new RegistroCampo(5,    6,     5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null,                  5000,   0   )}, //003
                {++c, new RegistroCampo(5,    11,    1,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null,                  ">"         )}, //004
                {++c, new RegistroCampo(5,    12,    1,  "A",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //005
                {++c, new RegistroCampo(5,    13,    4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     "1.66"                             )}, //006
                {++c, new RegistroCampo(5,    17,   10,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //007
                {++c, new RegistroCampo(5,    27,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //008
                {++c, new RegistroCampo(5,    44,   10,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //009
                {++c, new RegistroCampo(5,    54,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //010
                {++c, new RegistroCampo(5,    71,   10,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //011
                {++c, new RegistroCampo(5,    81,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //012
                {++c, new RegistroCampo(5,    98,   10,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //013
                {++c, new RegistroCampo(5,   108,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //014
                {++c, new RegistroCampo(5,   125,   10,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //015
                {++c, new RegistroCampo(5,   135,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //016
                {++c, new RegistroCampo(5,   152,   10,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //017
                {++c, new RegistroCampo(5,   162,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //018
                {++c, new RegistroCampo(5,   179,   10,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //019
                {++c, new RegistroCampo(5,   189,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //020
                {++c, new RegistroCampo(5,   206,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //021
                {++c, new RegistroCampo(5,   223,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //022
                {++c, new RegistroCampo(5,   240,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //023
                {++c, new RegistroCampo(5,   257,    3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //024
                {++c, new RegistroCampo(5,   260,   17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null,      null,       2,      true)}, //025
                {++c, new RegistroCampo(5,   277,    5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //026
                {++c, new RegistroCampo(5,   282,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //027
                {++c, new RegistroCampo(5,   299,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //028
                {++c, new RegistroCampo(5,   316,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     "J1"                               )}, //029
                {++c, new RegistroCampo(5,   333,    4,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     "2.66"                             )}, //030
                {++c, new RegistroCampo(5,   337,   10,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //031
                {++c, new RegistroCampo(5,   347,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //032
                {++c, new RegistroCampo(5,   364,   10,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //033
                {++c, new RegistroCampo(5,   374,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //034
                {++c, new RegistroCampo(5,   391,   10,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //035
                {++c, new RegistroCampo(5,   401,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //036
                {++c, new RegistroCampo(5,   418,   10,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //037
                {++c, new RegistroCampo(5,   428,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //038
                {++c, new RegistroCampo(5,   445,   10,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //039
                {++c, new RegistroCampo(5,   455,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //040
                {++c, new RegistroCampo(5,   472,   10,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //041
                {++c, new RegistroCampo(5,   482,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //042
                {++c, new RegistroCampo(5,   499,   10,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //043
                {++c, new RegistroCampo(5,   509,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //044
                {++c, new RegistroCampo(5,   526,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //045
                {++c, new RegistroCampo(5,   543,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //046
                {++c, new RegistroCampo(5,   560,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //047
                {++c, new RegistroCampo(5,   577,    3,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //048
                {++c, new RegistroCampo(5,   580,   17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null,      null,       2,      true)}, //049
                {++c, new RegistroCampo(5,   597,    5,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //050
                {++c, new RegistroCampo(5,   602,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //051
                {++c, new RegistroCampo(5,   619,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //052
                {++c, new RegistroCampo(5,   636,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     "J2"                               )}, //053
                {++c, new RegistroCampo(5,   653,    2,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //054
                {++c, new RegistroCampo(5,   655,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //055
                {++c, new RegistroCampo(5,   672,    6,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null,       null,   5,  false      )}, //056
                {++c, new RegistroCampo(5,   678,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //057
                {++c, new RegistroCampo(5,   695,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //058
                {++c, new RegistroCampo(5,   712,   17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     "K1",      null,       2,      true)}, //059
                {++c, new RegistroCampo(5,   729,    2,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //060
                {++c, new RegistroCampo(5,   731,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //061
                {++c, new RegistroCampo(5,   748,    6,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null,       null,   5,  false      )}, //062
                {++c, new RegistroCampo(5,   754,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //063
                {++c, new RegistroCampo(5,   771,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //064
                {++c, new RegistroCampo(5,   788,   17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     "K2",      null,       2,      true)}, //065
                {++c, new RegistroCampo(5,   805,    2,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //066
                {++c, new RegistroCampo(5,   807,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //067
                {++c, new RegistroCampo(5,   824,    6,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null,       null,   5,  false      )}, //068
                {++c, new RegistroCampo(5,   830,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //069
                {++c, new RegistroCampo(5,   847,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //070
                {++c, new RegistroCampo(5,   864,   17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     "K3",      null,       2,      true)}, //071
                {++c, new RegistroCampo(5,   881,    2,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //072
                {++c, new RegistroCampo(5,   883,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //073
                {++c, new RegistroCampo(5,   900,    6,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null,       null,   5,  false      )}, //074
                {++c, new RegistroCampo(5,   906,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //075
                {++c, new RegistroCampo(5,   923,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //076
                {++c, new RegistroCampo(5,   940,   17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     "K4",      null,       2,      true)}, //077
                {++c, new RegistroCampo(5,   957,    2,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //078
                {++c, new RegistroCampo(5,   959,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //079
                {++c, new RegistroCampo(5,   976,    6,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null,       null,   5,  false      )}, //080
                {++c, new RegistroCampo(5,   982,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //081
                {++c, new RegistroCampo(5,   999,   17,  "Num",  Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //082
                {++c, new RegistroCampo(5,  1016,   17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     "K5",      null,       2,      true)}, //083
                {++c, new RegistroCampo(5,  1033,   17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     "74",      null,       2,      true)}, //084
                {++c, new RegistroCampo(5,  1050,   17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     "75",      null,       2,      true)}, //085
                {++c, new RegistroCampo(5,  1067,   17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     "76",      null,       2,      true)}, //086
                {++c, new RegistroCampo(5,  1084,   17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     "77",      null,       2,      true)}, //087
                {++c, new RegistroCampo(5,  1101,   17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     "78",      null,       2,      true)}, //088
                {++c, new RegistroCampo(5,  1118,   17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     "79",      null,       2,      true)}, //089
                {++c, new RegistroCampo(5,  1135,   17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     "80",      null,       2,      true)}, //090
                {++c, new RegistroCampo(5,  1152,   17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     "81",      null,       2,      true)}, //091
                {++c, new RegistroCampo(5,  1169,   17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     "82",      null,       2,      true)}, //092
                {++c, new RegistroCampo(5,  1186,   17,  "N",    Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     "83",      null,       2,      true)}, //093
                {++c, new RegistroCampo(5,  1203,  150,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null                               )}, //094
                {++c, new RegistroCampo(5,  1353,   12,  "An",   Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],     null,        "</T39005000>"        )}, //095

            };


        }

        #endregion

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public override void Calcular()
        {
        }

        #endregion

    }
}

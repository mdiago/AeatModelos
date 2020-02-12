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
    
    Puede evitar el cumplimiento de lo establecido de lo establecido 
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
    /// Página 8 modelo 390.
    /// </summary>
    public class Mod390e2019v100p08 : RegistroModPagina
    {

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public Mod390e2019v100p08(string ejercicio, string periodo) : base(ejercicio, periodo)
        {

            string p = "008";   // clave página
            int c = 0;          // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {

                {++c, new RegistroCampo(8,       1,      2,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  "<T"        )}, //001
                {++c, new RegistroCampo(8,       3,      3,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  390,    0   )}, //002
                {++c, new RegistroCampo(8,       6,      5,     "Num",      Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  8000,   0   )}, //003
                {++c, new RegistroCampo(8,      11,      1,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,                  ">"         )}, //004
                {++c, new RegistroCampo(8,      12,      1,     "A",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //005
                {++c, new RegistroCampo(8,      13,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "139",      null,       2,      true)}, //006
                {++c, new RegistroCampo(8,      30,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "140",      null,       2,      true)}, //007
                {++c, new RegistroCampo(8,      47,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "141",      null,       2,      true)}, //008
                {++c, new RegistroCampo(8,      64,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "142",      null,       2,      true)}, //009
                {++c, new RegistroCampo(8,      81,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "143",      null,       2,      true)}, //010
                {++c, new RegistroCampo(8,      98,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "144",      null,       2,      true)}, //011
                {++c, new RegistroCampo(8,     115,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "145",      null,       2,      true)}, //012
                {++c, new RegistroCampo(8,     132,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "146",      null,       2,      true)}, //013
                {++c, new RegistroCampo(8,     149,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "147",      null,       2,      true)}, //014
                {++c, new RegistroCampo(8,     166,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "148",      null,       2,      true)}, //015
                {++c, new RegistroCampo(8,     183,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "149",      null,       2,      true)}, //016
                {++c, new RegistroCampo(8,     200,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "150",      null,       2,      true)}, //017
                {++c, new RegistroCampo(8,     217,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "151",      null,       2,      true)}, //018
                {++c, new RegistroCampo(8,     234,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "152",      null,       2,      true)}, //019
                {++c, new RegistroCampo(8,     251,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "640",      null,       2,      true)}, //020
                {++c, new RegistroCampo(8,     268,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "153",      null,       2,      true)}, //021
                {++c, new RegistroCampo(8,     285,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "154",      null,       2,      true)}, //022
                {++c, new RegistroCampo(8,     302,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "155",      null,       2,      true)}, //023
                {++c, new RegistroCampo(8,     319,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "156",      null,       2,      true)}, //024
                {++c, new RegistroCampo(8,     336,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "157",      null,       2,      true)}, //025
                {++c, new RegistroCampo(8,     353,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "158",      null,       2,      true)}, //026
                {++c, new RegistroCampo(8,     370,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "159",      null,       2,      true)}, //027
                {++c, new RegistroCampo(8,     387,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "160",      null,       2,      true)}, //028
                {++c, new RegistroCampo(8,     404,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "161",      null,       2,      true)}, //029
                {++c, new RegistroCampo(8,     421,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "162",      null,       2,      true)}, //030
                {++c, new RegistroCampo(8,     438,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "163",      null,       2,      true)}, //031
                {++c, new RegistroCampo(8,     455,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "164",      null,       2,      true)}, //032
                {++c, new RegistroCampo(8,     472,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "165",      null,       2,      true)}, //033
                {++c, new RegistroCampo(8,     489,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "166",      null,       2,      true)}, //034
                {++c, new RegistroCampo(8,     506,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "167",      null,       2,      true)}, //035
                {++c, new RegistroCampo(8,     523,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "168",      null,       2,      true)}, //036
                {++c, new RegistroCampo(8,     540,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "169",      null,       2,      true)}, //037
                {++c, new RegistroCampo(8,     557,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "641",      null,       2,      true)}, //038
                {++c, new RegistroCampo(8,     574,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "170",      null,       2,      true)}, //039
                {++c, new RegistroCampo(8,     591,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "171",      null,       2,      true)}, //040
                {++c, new RegistroCampo(8,     608,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "172",      null,       2,      true)}, //041
                {++c, new RegistroCampo(8,     625,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "173",      null,       2,      true)}, //042
                {++c, new RegistroCampo(8,     642,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "174",      null,       2,      true)}, //043
                {++c, new RegistroCampo(8,     659,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "175",      null,       2,      true)}, //044
                {++c, new RegistroCampo(8,     676,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "176",      null,       2,      true)}, //045
                {++c, new RegistroCampo(8,     693,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "177",      null,       2,      true)}, //046
                {++c, new RegistroCampo(8,     710,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "178",      null,       2,      true)}, //047
                {++c, new RegistroCampo(8,     727,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "179",      null,       2,      true)}, //048
                {++c, new RegistroCampo(8,     744,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "180",      null,       2,      true)}, //049
                {++c, new RegistroCampo(8,     761,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "181",      null,       2,      true)}, //050
                {++c, new RegistroCampo(8,     778,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "182",      null,       2,      true)}, //051
                {++c, new RegistroCampo(8,     795,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "183",      null,       2,      true)}, //052
                {++c, new RegistroCampo(8,     812,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "184",      null,       2,      true)}, //053
                {++c, new RegistroCampo(8,     829,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "185",      null,       2,      true)}, //054
                {++c, new RegistroCampo(8,     846,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "186",      null,       2,      true)}, //055
                {++c, new RegistroCampo(8,     863,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "642",      null,       2,      true)}, //056
                {++c, new RegistroCampo(8,     880,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "187",      null,       2,      true)}, //057
                {++c, new RegistroCampo(8,     897,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "188",      null,       2,      true)}, //058
                {++c, new RegistroCampo(8,     914,     17,     "N",        Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    "189",      null,       2,      true)}, //059
                {++c, new RegistroCampo(8,     931,    150,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null                               )}, //060
                {++c, new RegistroCampo(8,    1081,     12,     "An",       Txt.Den[$"{p}.{("" + c).PadLeft(3,'0')}"],    null,        "</T39008000>"        )}, //061

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

﻿/*
    Este archivo es parte del proyecto AeatModelos.
    Copyright (c) 2020 Irene Solutions SL
    Autores: Irene Solutions SL.

    Este programa es software libre; usted puede redistribuirlo y/o modificarlo
    bajo los términos establecidos en GNU Affero General Public License versión 3
    tal y como han sido publicados por la Free Software Foundation.

    Este programa se distribuye con la intención de que sea útil, pero SIN
    NIGÚN TIPO DE GARANTÍA.

    Para más detalles consulte la licencia GNU Affero General Public.
    Debe se haber recibido una copia de la misma con el presente programa;
    en caso contrario, consulte http://www.gnu.org/licenses o escriba a la 
    Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
    Boston, MA, 02110-1301 USA, o descargue la licencia en la URL:
        http://www.irenesolutions.com/terms-of-use.pdf
    
    Las interfaces de ususario con código modificado y versiones de los
    objetos contenidos en el presente programa deben mostrar las advertencias
    legaels apropiadas, como se requiere en la secion 5 de la licencia GNU Affero
    General Public.

    Usted puede ser liberado de los requerimiento de la licencia mediante
    la compra de una licencia comercial. La compra de la licencia es
    obligatoria en caso de que vaya a desarrollar actividades comerciales
    con el software AeatModelos sin publicar el código fuente de sus 
    propias aplicaciones.
    Estas actividades incluyen: ofrecer servicios de pago como mediante ASP,
    sirviendo los resultados obtenidos mediante el presente software mediante
    aplicaciones web, o empaquetando AeatModelos con un producto de código
    fuente no público.    
       
    Para más información, por favor contacte a Irene Solutions SL. en la
    dirección: info@irenesolutions.com
 */

using System;

namespace AeatModelos.Conversores
{

    /// <summary>
    /// Se encarga de las funciones de conversión de valores
    /// apara un campo.
    /// </summary>
    public class ConversorTexto : Conversor
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="registroCampo">Registro campo subyacente.</param>
        public ConversorTexto(RegistroCampo registroCampo) : base(registroCampo)
        {
        }

        /// <summary>
        /// Recupera la representación del 
        /// segmento de fichero preparada para incorporarse
        /// al mismo.
        /// </summary>
        /// <returns> Representación del 
        /// segmento de fichero preparada para incorporarse
        /// al mismo.</returns>
        public override string AFichero()
        {

            string resultado = $"{_RegistroCampo.Valor}";
            int largoPendiente = _RegistroCampo.Longitud - resultado.Length;

            if (largoPendiente < 0)
                throw new InvalidCastException($"Ha intentado asignar el valor '{resultado}'" +
                    $" con una longitud de {resultado.Length} al registro '{_RegistroCampo.Descripcion}'" +
                    $" que sólo admite una longitud de {_RegistroCampo.Longitud}.");

            string relleno = null;

            if (largoPendiente > 0)
                relleno = new string(' ', largoPendiente);

            resultado = $"{resultado}{relleno}";

            if(_RegistroCampo.ValorFichero != resultado)
                _RegistroCampo.ValorFichero = resultado;

            if (resultado.Length > _RegistroCampo.Longitud)
                resultado = resultado.Substring(resultado.Length - 
                    _RegistroCampo.Longitud, _RegistroCampo.Longitud);

            return resultado;

        }

        /// <summary>
        /// Obtiene un datos formateado procedente de un fichero.
        /// </summary>
        /// <returns> Dato utilizable por la aplicación
        /// procedente de su representación en un fichero.</returns>
        public override object DeFichero()
        {
            string resultado = $"{_RegistroCampo.ValorFichero}";
            resultado = resultado.Trim(" ".ToCharArray());

            if ((_RegistroCampo.Valor == null) || (_RegistroCampo.Valor != null && !_RegistroCampo.Valor.Equals(resultado)))
                _RegistroCampo.Valor = resultado;
          
            return resultado;
        }

    }
}

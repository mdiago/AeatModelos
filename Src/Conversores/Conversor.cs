﻿/*
    Este archivo es parte del proyecto AeatModelos.
    Copyright (c) 2018 Irene Solutions SL
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
    /// Se encarga de hacer la conversión de los datos
    /// entrados desde fichero, y de los datos de salida
    /// para fichero.
    /// </summary>
    public class Conversor : IConversor
    {

        /// <summary>
        /// Campo subyacente.
        /// </summary>
        protected RegistroCampo _RegistroCampo;

        /// <summary>
        /// Valor del campo.
        /// </summary>
        public object Valor
        {
            get
            {
                return _RegistroCampo.Valor;
            }
            set
            {
                _RegistroCampo.Valor = value;
            }
        }

        /// <summary>
        /// Descripción del campo.
        /// </summary>
        public string Descripcion
        {
            get
            {
                return _RegistroCampo.Descripcion;
            }
        }

        /// <summary>
        /// Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.
        /// </summary>
        /// <param name="descripcion">Descipción del campo.</param>
        /// <returns>Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.</returns>
        public RegistroCampo this[string descripcion]
        {
            get
            {
                throw new NotImplementedException("Pendiente!!!");
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="registroCampo">Registro campo subyacente.</param>
        public Conversor(RegistroCampo registroCampo)
        {
            _RegistroCampo = registroCampo;
        }

        /// <summary>
        /// Recupera la representación del 
        /// segmento de fichero preparada para incorporarse
        /// al mismo.
        /// </summary>
        /// <returns> Representación del 
        /// segmento de fichero preparada para incorporarse
        /// al mismo.</returns>
        public virtual string AFichero()
        {
            throw new NotImplementedException("Pendiente!!!");
        }

        /// <summary>
        /// Obtiene un datos formateado procedente de un fichero.
        /// </summary>
        /// <returns> Dato utilizable por la aplicación
        /// procedente de su representación en un fichero.</returns>
        public virtual object DeFichero()
        {
            throw new NotImplementedException("Pendiente!!!");
        }

    }
}

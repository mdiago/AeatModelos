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
using System.Collections.Generic;
using System.Text;

namespace AeatModelos
{

    /// <summary>
    /// Conjunto de elementos empaquetables. 
    /// Grupo de objetos que se puede representar mediante segmentos de 
    /// texto válidos para incluir en un resgistro de la aeat; Y que a su
    /// vez puede ser representado también como un segmento válido generado
    /// mediante la concatenación de sus elmentos hijo-
    /// </summary>
    public class ConjuntoDeEmpaquetables : IEmpaquetable
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public ConjuntoDeEmpaquetables(): this("Paginas")
        {            
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="descripcion">Descripción del conjunto de empaquetables.</param>
        public ConjuntoDeEmpaquetables(string descripcion)
        {
            Descripcion = descripcion;
        }

        /// <summary>
        /// Valor del campo.
        /// </summary>
        public object Valor
        {
            get
            {
                throw new NotImplementedException("Pendiente!!!!!");
            }
            set
            {
                throw new NotImplementedException("Pendiente!!!!!");
            }
        }

        /// <summary>
        /// Descripción del campo.
        /// </summary>
        public string Descripcion { get; private set; }

        /// <summary>
        /// Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.
        /// </summary>
        /// <param name="descripcion">Descripción del campo.</param>
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
        /// Lista de elementos empaquetables
        /// que compone el conjunto.
        /// </summary>
        public List<IEmpaquetable> Empaquetables { get; set; }

        /// <summary>
        /// Recupera la representación del 
        /// segmento de fichero preparada para incorporarse
        /// al mismo.
        /// </summary>
        /// <returns> Representación del 
        /// segmento de fichero preparada para incorporarse
        /// al mismo.</returns>
        public string AFichero()
        {
            StringBuilder constructorTexto = new StringBuilder();

            foreach (IEmpaquetable entrada in Empaquetables)
                constructorTexto.Append(entrada.AFichero());

            return constructorTexto.ToString();

        }

        /// <summary>
        /// Compone un empaquetable a partir de su forma
        /// en texto de fichero.
        /// </summary>
        /// <param name="texto">Segmento de texto.</param>
        /// <returns>Objeto IEmpaquetable representado 
        /// por el segmento de texto</returns>
        public object DeFichero(string texto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Implementación del IComparable.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            return 0;
        }
    }
}

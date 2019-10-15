///////////////////////////////////////////////////////////
//  EstadoEnCurso.cs
//  Implementation of the Class EstadoEnCurso
//  Generated by Enterprise Architect
//  Created on:      13-oct.-2019 22:31:16
//  Original author: CYRO
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace CU71
{
    public class EstadoEnCurso : EstadoIntervencion
    {
        private DateTime fecha;

        public EstadoEnCurso(DateTime fecha)
        {
            this.fecha = fecha;
        }
        /// 
        /// <param name="fecha"></param>
        /// <param name="this"></param>
        public Boolean abortar(DateTime fecha, Intervencion inter)
        {

            throw new NotImplementedException();
        }

        public Boolean esEnCurso()
        {
            return true;
        }

        /// 
        /// <param name="fecha"></param>
        /// <param name="this"></param>
        public Boolean finalizar(DateTime fecha, Intervencion inter)
        {
            try{
                EstadoIntervencion nuevo = new EstadoFinalizada(fecha);
                inter.anadirEstado(nuevo);
                return true;
            }
            catch(Exception ex){
                //rollback()
                return false;
            }
        }
	}

}//end EstadoEnCurso

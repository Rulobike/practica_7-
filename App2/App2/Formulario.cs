using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace App2
{
    [Table("Formulario")]

    public class Formulario
    {
        string id;
        string nombre;
        string apellidos;
        string direccion;
        string telefono;
        string carrera;
        string semestre;
        string correo;
        string git;

        [PrimaryKey, Unique, MaxLength(10)]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        [Column("Nombre"), MaxLength(15)]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        [Column("Apellidos"), MaxLength(30)]
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        [Column("Direccion"), MaxLength(30)]
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        [Column("Telefono"), MaxLength(10)]
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        [Column("Carrera"), MaxLength(20)]
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        [Column("Semestre"), MaxLength(5)]
        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }
        [Column("Correo"), MaxLength(30)]
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        [Column("GitHub"), MaxLength(20)]
        public string Git
        {
            get { return git; }
            set { git = value; }
        }
    }
}

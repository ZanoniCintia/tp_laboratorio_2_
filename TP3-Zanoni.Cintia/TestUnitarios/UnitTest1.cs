using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesAbstractas;
using ClasesInstanciables;
using Excepciones;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidaColecciones()
        {   
            //Arrange :
            Universidad uni = new Universidad();
            Profesor i1 = new Profesor(1, "Juan", "Lopez", "12224458",
            EntidadesAbstractas.Persona.ENacionalidad.Argentino);

            //Act :
            uni += i1;

            //Assert :

            Assert.IsNotNull(uni.Instructores);
        }

        [TestMethod]
        public void ValidaCaracterNumerico()
        {   
            //Arrange :
            Alumno a = new Alumno(1, "Joe", "3", "3015729", Persona.ENacionalidad.Argentino, 
                Universidad.EClases.Laboratorio);

            //Assert :
            Assert.IsInstanceOfType(a.DNI, typeof(int));
        }

        [TestMethod]
        public void ValidaNacionalidad()
        {
            //Arrange :
            Persona nuevaPersona = new Alumno(1, "Bry", "Barrios", "32555667", Persona.ENacionalidad.Argentino,
                Universidad.EClases.Laboratorio);

            //Assert :
            
           Assert.IsTrue((nuevaPersona.DNI >= 0 && nuevaPersona.DNI <= 89999999) && (nuevaPersona.Nacionalidad == Persona.ENacionalidad.Argentino));
        }
    }
}

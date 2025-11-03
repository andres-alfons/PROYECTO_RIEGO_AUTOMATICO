using DAL;
using ENTITY;
using System.Collections.ObjectModel;

namespace BLL
{
    public class ServiciosPlanta: ICrudEscritura<Cultivo>, ICrudLectura<Cultivo>
    {
            PlantaRepository plantaRepository;
            public ServiciosPlanta()
            {
                plantaRepository = new PlantaRepository(Utils.ARC_PLANTAS);
            }

            public bool Actualizar(Cultivo entidad)
            {
                return plantaRepository.Actualizar(entidad);
            }

            public ReadOnlyCollection<Cultivo> MostrarTodos()
            {
                var lista = plantaRepository.MostrarTodos();
                return new ReadOnlyCollection<Cultivo>(lista);
            }

            public bool Eliminar(Cultivo entidad)
            {
                return plantaRepository.Eliminar(entidad);
            }

            public string Guardar(Cultivo entidad)
            {
                return plantaRepository.Guardar(entidad);
            }

            public Cultivo ObtenerPorId(int id)
            {
                return plantaRepository.ObtenerPorId(id);
            }
        }
    }

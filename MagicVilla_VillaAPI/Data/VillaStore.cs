using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO{ Id = 1, Name = "Pool View" },
                new VillaDTO{ Id = 2, Name = "Beach View" },
                new VillaDTO{ Id = 3, Name = "Pier View" },
                new VillaDTO{ Id = 4, Name = "Ocean View" },
                new VillaDTO{ Id = 5, Name = "Garden Window" }
            };
    }
}

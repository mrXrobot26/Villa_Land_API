using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillaLand.Models.DTO;

namespace VillaLand.Models.DataStore
{
    public static class VillaStore
    {
        public static List<VillaDTO> VillaList = new List<VillaDTO>{
                new VillaDTO { Id =1, Name ="bool view"},
                new VillaDTO { Id =2,Name="Beach View"}
         };
    }
}

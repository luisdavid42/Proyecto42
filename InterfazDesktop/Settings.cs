using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace InterfazDesktop
{
    [Serializable]
    public class Settings: ISerializable
    {
        bool calcularAutomaticamente=false;

        

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}

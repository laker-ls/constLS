using ConstLS.Memory.Parameters.RawParameters;
using System;

namespace ConstLS.Memory.Parameters
{
    class MobParameters : MobRawParameters
    {
        public MobParameters(ClientMemory clientMemory) :base(clientMemory) {}

        public string typeAsString()
        {
            switch (this.type()) {
                case 6:
                    return "Mob";
                case 7:
                    return "NPC";
                case 9:
                    return "Pet";
                default:
                    throw new Exception("Получено не корректно значение.");
            }
        }

        public Coordinates coordinateInGameFormat()
        {
            Coordinates rawCoordinates = this.coordinateRaw();
            Coordinates coordinatesInGameFormat = new Coordinates();
            coordinatesInGameFormat.x = ((rawCoordinates.x + 4000) / 10);
            coordinatesInGameFormat.y = ((rawCoordinates.y + 5500) / 10);
            coordinatesInGameFormat.z = (rawCoordinates.z / 10);
            return coordinatesInGameFormat;
        }

        public int percentHP() { return (this.HP() / (this.maxHP() / 100)); }
    }
}

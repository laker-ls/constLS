using ConstLS.Memory.Parameters.RawParameters;
using System;

namespace ConstLS.Memory.Parameters
{
    class SelfParameters : SelfRawParameters
    {
        public SelfParameters(ClientMemory clientMemory) :base(clientMemory) {}

        public string typeAsString()
        {
            switch (this.type()) {
                case 0:
                    return "Warrior";
                case 1:
                    return "Mage";
                case 3:
                    return "Druid";
                case 4:
                    return "Tank";
                case 6:
                    return "Archer";
                case 7:
                    return "Priest";
                default:
                    throw new Exception("Получено не корректное значение.");
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
        public int percentMP() { return (this.MP() / (this.maxMP() / 100)); }

        public bool isExist() {
            if (this.Personage() != 0) {
                return true;
            }
            return false;
        }
    }
}

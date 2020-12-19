using ConstLS.Memory.Parameters.RawParameters;
using System;

namespace ConstLS.Memory.Parameters
{
    class MobParameters : MobRawParameters
    {
        public MobParameters(ClientMemory clientMemory) :base(clientMemory) {}

        public string type()
        {
            switch (this.rawType()) {
                case 6: return "Mob";
                case 7: return "NPC";
                case 9: return "Pet";
                default: throw new Exception("Получено не корректно значение.");
            }
        }

        public string feature()
        {
            switch (this.rawFeature()) {
                case 0: return "";
                case 1: return "acceleration";
                case 2: return "pacifist";
                case 3: return "pDef";
                case 4: return "mDef";
                case 5: return "pAtack";
                case 6: return "mAtack";
                case 7: return "berserk";
                case 8: return "increasedHP";
                case 9: return "weak";
                default: throw new Exception("Получено не корректное значение.");
            }
        }

        public string action()
        {
            switch (this.rawAction()) {
                case 0: return "passive";
                case 2: return "pAtack";
                case 3: return "mAtack";
                case 4: return "died";
                case 5: return "moving";
                default: throw new Exception("Получено не корректное значение");
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

        public int HPpercent() {
            if (this.HP() != 0) {
                return (this.HP() / (this.HPmax() / 100));
            }
            return 0;
        }

        public bool isExist()
        {
            if (this.currentMobWID != -1) {
                return true;
            }
            return false;
        }
    }
}

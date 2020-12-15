using ConstLS.Memory.RawParameters;

namespace ConstLS.Unit.Parameters
{
    abstract class BaseParameters
    {
        protected IRawParameters rawParameters;

        public struct Coordinates
        {
            public float x, y, z;
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

        public Coordinates coordinateRaw()
        {
            Coordinates rawCoordinates = new Coordinates();
            rawCoordinates.x = this.rawParameters.x();
            rawCoordinates.y = this.rawParameters.y();
            rawCoordinates.z = this.rawParameters.z();
            return rawCoordinates;
        }

        public int percentHP() { return (rawParameters.HP() / (rawParameters.maxHP() / 100)); }
    }
}

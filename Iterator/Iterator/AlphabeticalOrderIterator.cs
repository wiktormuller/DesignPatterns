namespace Iterator
{
    public class AlphabeticalOrderIterator : Iterator
    {
        private WordCollection _collection;
        private int _position = -1;
        private bool _reverse = false;

        public AlphabeticalOrderIterator(WordCollection collection, bool reverse = false)
        {
            _collection = collection;
            _reverse = reverse;

            if (reverse)
            {
                _position = collection.getItems().Count;
            }
        }

        public override int Key()
        {
            return _position;
        }

        public override object Current()
        {
            return _collection.getItems()[_position];
        }

        public override bool MoveNext()
        {
            int updatedPosition = this._position + (this._reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this._collection.getItems().Count)
            {
                this._position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            this._position = this._reverse ? this._collection.getItems().Count - 1 : 0;
        }
    }
}
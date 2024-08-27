using System;

namespace editor.cfg
{
    public partial class Tables
    {
        public void MoveTab()
        {
            var index = Array.IndexOf(_tableNames, _currentTable);
            var length = _tableNames.Length;
            var nextIndex = (index + 1) % length;
            _currentTable = _tableNames[nextIndex];
        }
    }
}

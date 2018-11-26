namespace Madlibs.Models
{
    public class MadlibVariable
    {
        private string _name;
        private string _nameTwo;
        private string _animal;
        private string _adjective;
        private string _exclamation;

        public string GetName()
        {
            return _name;
        }

        public void SetName(string newName)
        {
            _name = newName;
        }

        public string GetNameTwo()
        {
            return _nameTwo;
        }

        public void SetNameTwo(string newNameTwo)
        {
            _nameTwo = newNameTwo;
        }

        public string GetAnimal()
        {
            return _animal;
        }
        
        public void SetAnimal(string newAnimal)
        {
            _animal = newAnimal;
        }
        public string GetAdjective()
        {
            return _adjective;
        }
        
        public void SetAdjective(string newAdjective)
        {
            _adjective = newAdjective;
        }
        public string GetExclamation()
        {
            return _exclamation;
        }
        
        public void SetExclamation(string newExclamation)
        {
            _exclamation = newExclamation;
        }
    }
}
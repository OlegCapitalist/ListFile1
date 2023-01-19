using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFile1.Services
{
    public class CodeGenerator
    {
        #region Private Fields

        private string _range;
        private string _letterRange;
        private string _numberRange;
        private string _template;
        private int _length;
        private int _amount;

        private const char _letterTemplate = '!';
        private const char _numberTemplate = '@';
        private const string _validCharsForTemplate = " -!@";

        private Func<string> _generateCode;

        #endregion

        #region Constructors

        public CodeGenerator(string range, int length, int amount)
        {
            if (length < 3)
                throw new ArgumentOutOfRangeException("Length must be greater than 3", nameof(length));
            
            _length = length;
            _amount = amount;

            SlipRange(range.Trim());

            if (CountCombinationsWithLength() < amount)
                throw new ArgumentOutOfRangeException("Amount is greater than the number of possible combinations", nameof(amount));

            _generateCode = GenerateCodeWithLength;
        }

        public CodeGenerator(string range, string template, int amount)
        {
            CheckValidTemplate(template);
            //_template = template.Where(x => _validCharsForTemplate.Contains(Convert.ToChar(x)));

            _template = template;
            _amount = amount;

            SlipRange(range.Trim());

            if (CountCombinationsWithTemplate() < amount)
                throw new ArgumentOutOfRangeException("Amount is greater than the number of possible combinations", nameof(amount));

            _generateCode = GenerateCodeWithTemplate;
        }

        #endregion

        #region Public Methods

        public List<string> GetCodes()
        {
            var codes = new List<string>();

            for (int i = 0; i < _amount; i++)
            {
                string code = "";

                bool contains = true;
                while (contains)
                {
                    code = _generateCode.Invoke();

                    contains = codes.Contains(code);
                }
                codes.Add(code);
            }

            return codes;
        }

        #endregion

        #region Private Methods

        private string GenerateCodeWithTemplate()
        {
            var rnd = new Random();
            string result = "";

            foreach (char ch in _template)
            {
                if (ch == _letterTemplate)
                {
                    result = result + _letterRange[rnd.Next(_letterRange.Count())];
                }
                else if (ch == _numberTemplate)
                {
                    result = result + _numberRange[rnd.Next(_numberRange.Count())];
                }
                else
                {
                    result = result + ch;
                }
            }

            return result;
        }

        private string GenerateCodeWithLength()
        {
            var rnd = new Random();
            string result = "";

            for(int i = 0; i < _length; i++)
            {
                result = result + _range[rnd.Next(_range.Count())];
            }

            return result;
        }

        private void CheckValidTemplate(string template)
        {
            foreach(char ch in template)
            {
                if (!_validCharsForTemplate.Contains(ch))
                    throw new ArgumentException("Invalid template", nameof(template));
            }
        }

        private int CountCombinationsWithTemplate()
        {
            int countLetters = _template.Count(x => x == _letterTemplate);
            int countNumbers = _template.Count(x => x == _numberTemplate);

            return Convert.ToInt32(Math.Floor(Math.Pow(_letterRange.Count(), countLetters))) +
                Convert.ToInt32(Math.Floor(Math.Pow(_numberRange.Count(), countNumbers)));
        }

        private int CountCombinationsWithLength()
        {
            return Convert.ToInt32(Math.Floor(Math.Pow(_range.Count(), _length)));
        }

        private void SlipRange(string range)
        {
            _letterRange = "";
            _numberRange = "";

            foreach (char ch in range)
            {
                if (char.IsLetter(ch))
                {
                    if (!_letterRange.Contains(ch))
                        _letterRange = _letterRange + ch;
                }
                else if (char.IsDigit(ch))
                {
                    if (!_numberRange.Contains(ch))
                        _numberRange = _numberRange + ch;
                }
            }

            _range = _letterRange + _numberRange;
        }

        #endregion
    }
}

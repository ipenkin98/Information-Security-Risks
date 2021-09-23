using Information_Security_Risks.ViewModel.Base;
using System;
using System.Collections.Generic;
using LiveCharts;
using LiveCharts.Wpf;
using System.Text;
using System.Windows;
using Information_Security_Risks.Commands;
using System.Windows.Input;
using Information_Security_Risks.Models;

namespace Information_Security_Risks.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        #region Свойства 
        private int _addResult1;
        public int AddResult1
        {
            get { return _addResult1; }
            set
            {
                _addResult1 = value;
                if (value > 10)
                {
                    _addResult1 = 10;
                }
                else if (value <= 0)
                {
                    _addResult1 = 1;
                }
                OnPropertyChanged(nameof(AddResult1));
                OnPropertyChanged(("Risks"));
            }
        }

        private int _addResult2;
        public int AddResult2
        {
            get { return _addResult2; }
            set
            {
                _addResult2 = value;
                if (value > 10)
                {
                    _addResult2 = 10;
                }
                else if (value <= 0)
                {
                    _addResult2 = 1;
                }
                OnPropertyChanged(nameof(AddResult2));
                OnPropertyChanged(("Risks"));
            }
        }

        private int _addResult3;
        public int AddResult3
        {
            get { return _addResult3; }
            set
            {
                _addResult3 = value;
                if (value > 10)
                {
                    _addResult3 = 10;
                }
                else if (value <= 0)
                {
                    _addResult3 = 1;
                }
                OnPropertyChanged(nameof(AddResult3));
                OnPropertyChanged(("Risks"));
            }
        }
        private int _addResult4;
        public int AddResult4
        {
            get { return _addResult4; }
            set
            {
                _addResult4 = value;
                if (value > 10)
                {
                    _addResult4 = 10;
                }
                else if (value <= 0)
                {
                    _addResult4 = 1;
                }
                OnPropertyChanged(nameof(AddResult4));
                OnPropertyChanged(("SLE"));
            }
        }

        private int _addResult5;
        public int AddResult5
        {
            get { return _addResult5; }
            set
            {
                _addResult5 = value;
                if (value > 10)
                {
                    _addResult5 = 10;
                }
                else if (value <= 0)
                {
                    _addResult5 = 1;
                }
                OnPropertyChanged(nameof(AddResult5));
                OnPropertyChanged(("ALE"));
            }
        }

        private double _assets;

        double max = 99999999999;
        public double Assets
        {
            get { return _assets; }
            set
            {
                _assets = value;
                if (value >= max)
                {
                    _assets = max;
                }
                else if (value <= 0)
                {
                    _assets = 1;
                }
                OnPropertyChanged(nameof(Assets));
                OnPropertyChanged(("SLE"));
                OnPropertyChanged(("ALE"));
            }
        }


        #endregion

        #region Кнопки добавить и убавить значения
        public ICommand ClsickAdd1
        {
            get
            {
                return new LambdaCommand((obj) =>
                {
                    AddResult1++;
                });
            }
        }

        public ICommand ClsickRemove1
        {
            get
            {
                return new LambdaCommand((obj) =>
                {
                    AddResult1--;
                });
            }
        }
        public ICommand ClsickAdd2
        {
            get
            {
                return new LambdaCommand((obj) =>
                {
                    AddResult2++;
                });
            }
        }

        public ICommand ClsickRemove2
        {
            get
            {
                return new LambdaCommand((obj) =>
                {
                    AddResult2--;
                });
            }
        }
        public ICommand ClsickAdd3
        {
            get
            {
                return new LambdaCommand((obj) =>
                {
                    AddResult3++;
                });
            }
        }

        public ICommand ClsickRemove3
        {
            get
            {
                return new LambdaCommand((obj) =>
                {
                    AddResult3--;
                });
            }
        }
        public ICommand ClsickAdd4
        {
            get
            {
                return new LambdaCommand((obj) =>
                {
                    AddResult4++;
                });
            }
        }

        public ICommand ClsickRemove4
        {
            get
            {
                return new LambdaCommand((obj) =>
                {
                    AddResult4--;
                });
            }
        }
        public ICommand ClsickAdd5
        {
            get
            {
                return new LambdaCommand((obj) =>
                {
                    AddResult5++;
                });
            }
        }

        public ICommand ClsickRemove5
        {
            get
            {
                return new LambdaCommand((obj) =>
                {
                    AddResult5--;
                });
            }
        }
        #endregion

        public int Risks
        {
            get
            {
                return Calculation_risks.Risks(AddResult1, AddResult2, AddResult3);
            }
        }

        public double SLE
        {
            get 
            {
                return Calculation_risks.SLE(AddResult4, Assets);
            }
            set{ OnPropertyChanged(("ALE")); }
        
        }
        public double ALE
        {
            get
            {
                return Calculation_risks.ALE((int)SLE, AddResult5);
            }

        }
    }
}

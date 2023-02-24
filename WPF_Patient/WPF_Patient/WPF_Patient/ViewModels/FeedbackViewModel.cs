using Controller.PatientController;
using Model.Patient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Patient.Commands;
using WPF_Patient.Xml;
using Type = Model.Patient.Type;

namespace WPF_Patient.ViewModels
{
    class FeedbackViewModel : BindableBase
    {
        private XmlReaderWriter xmlReaderWriter;

        private PatientController patientController;
        public ObservableCollection<Type> FeedbackType { get; set; }

        public MyICommand CancelCommand { get; set; } 
        public delegate void CancelEventHandler(object source, EventArgs args);
        public event CancelEventHandler Cancelling;

        public string id;
        public string text;
        public Type type;

        public string Id
        {
            get { return id; }
            set
            {
                SetField(ref id, value);
                SubmitCommand.RaiseCanExecuteChanged();
            }
        }
        public string Text
        {
            get { return text; }
            set
            {
                SetField(ref text, value);
                SubmitCommand.RaiseCanExecuteChanged();
            }
        }

        public MyICommand SubmitCommand { get; set; }

        public FeedbackViewModel()
        {
            SubmitCommand = new MyICommand(OnSubmiting, SubmitCanExecute);
            patientController = new PatientController();
            FeedbackType = new ObservableCollection<Type>();
            FeedbackType.Add(Type.Comment); 
            FeedbackType.Add(Type.ReportProblem);
            FeedbackType.Add(Type.Question);
            xmlReaderWriter = new XmlReaderWriter();
            CancelCommand = new MyICommand(OnCancelling);
        }

        private bool SubmitCanExecute()
        {

            return true;
        }

        private void OnSubmiting()
        {
            Feedback newFeedback = new Feedback();
            //newFeedback.Id = Id;
            //newFeedback.Text = Text;

            patientController.SubmitFeedback(newFeedback);
        }

        private void OnCancelling()
        {
            Cancelling?.Invoke(this, null);

        }
    }
}

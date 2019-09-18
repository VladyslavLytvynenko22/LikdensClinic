namespace LikdensClinic.Presenter
{
    interface IMainPresenter : IPresenter
    {
        void Run();
        void OpenPatient(string idPatient);
    }
}

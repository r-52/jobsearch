namespace jobsearch.Core.Models.EF
{
    public class LanguageEntity : BaseKeyModel<int>
    {
        private ILazyLoader _lazyLoader;


        public LanguageEntity()
        {

        }

        private LanguageEntity(ILazyLoader _loader)
        {
            this._lazyLoader = _loader;
        }

        public string Name { get; set; }


        private List<TranslationEntity> _translations;

        public List<TranslationEntity> Translations => this._lazyLoader.Load(this, ref this._translations);

    }
}
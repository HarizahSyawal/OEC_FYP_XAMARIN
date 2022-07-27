using AIO.IDOS3.Mobile.Data.Entity;
using System;
using System.ComponentModel;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class EditNewCustomerModel : BindableErrorBase
    {

        #region Constructors

        public EditNewCustomerModel()
        {
            SalesmanOptions.IsRequired = true;
            SalesmanOptions.Caption = "Site";

            MobileCodeOptions.Caption = "Mobile Code";

            RegisteredDateOptions.Caption = "Registered Date";

            NameOptions.IsRequired = true;
            NameOptions.Caption = "Name";

            Category1Options.IsRequired = true;
            Category1Options.Caption = "Customer Type";

            Category3Options.IsRequired = true;
            Category3Options.Caption = "Customer Location";


            ContactPersonOptions.IsRequired = true;
            ContactPersonOptions.Caption = "Contact Person";

            Address1Options.IsRequired = true;
            Address1Options.Caption = "Address";

            CityOptions.IsRequired = true;
            CityOptions.Caption = "City";

            StateProvinceOptions.IsRequired = true;
            StateProvinceOptions.Caption = "State/Province";

            ZipCodeOptions.IsRequired = true;
            ZipCodeOptions.Caption = "Zip Code";

            Phone1Options.IsRequired = true;
            Phone1Options.Caption = "Phone";


            TaxIDNumberOptions.IsRequired = true;
            TaxIDNumberOptions.Caption = "Tax ID Number";

            TaxIDNameOptions.IsRequired = true;
            TaxIDNameOptions.Caption = "Tax ID Name";

            TaxAddress1Options.IsRequired = true;
            TaxAddress1Options.Caption = "Address";
        }

        #endregion

        #region Properties

        public mvCustomer Customer { get; set; }



        private ComboBoxEditOptions<mvSalesman> salesmanOptions = new ComboBoxEditOptions<mvSalesman>();
        public ComboBoxEditOptions<mvSalesman> SalesmanOptions { get { return salesmanOptions; } set { SetProperty(ref salesmanOptions, value); } }
        private Guid? salesmanID = null;
        public Guid? SalesmanID { get { return salesmanID; } set { SetProperty(ref salesmanID, value); } }

        private TextEditOptions<string> mobileCodeOptions = new TextEditOptions<string>();
        public TextEditOptions<string> MobileCodeOptions { get { return mobileCodeOptions; } set { SetProperty(ref mobileCodeOptions, value); } }
        private string mobileCode = null;
        public string MobileCode { get { return mobileCode; } set { SetProperty(ref mobileCode, value); } }

        private DateEditOptions<DateTime> registeredDateOptions = new DateEditOptions<DateTime>();
        public DateEditOptions<DateTime> RegisteredDateOptions { get { return registeredDateOptions; } set { SetProperty(ref registeredDateOptions, value); } }
        private DateTime? registeredDate = null;
        public DateTime? RegisteredDate { get { return registeredDate; } set { SetProperty(ref registeredDate, value); } }

        private TextEditOptions<string> nameOptions = new TextEditOptions<string>();
        public TextEditOptions<string> NameOptions { get { return nameOptions; } set { SetProperty(ref nameOptions, value); } }
        private string name = null;
        public string Name { get { return name; } set { SetProperty(ref name, value); } }

        private ComboBoxEditOptions<mvCustomerCategory> category1Options = new ComboBoxEditOptions<mvCustomerCategory>();
        public ComboBoxEditOptions<mvCustomerCategory> Category1Options { get { return category1Options; } set { SetProperty(ref category1Options, value); } }
        private int? category1ID = null;
        public int? Category1ID { get { return category1ID; } set { SetProperty(ref category1ID, value); } }

        private ComboBoxEditOptions<mvCustomerCategory> category3Options = new ComboBoxEditOptions<mvCustomerCategory>();
        public ComboBoxEditOptions<mvCustomerCategory> Category3Options { get { return category3Options; } set { SetProperty(ref category3Options, value); } }
        private int? category3ID = null;
        public int? Category3ID { get { return category3ID; } set { SetProperty(ref category3ID, value); } }


        private TextEditOptions<string> contactPersonOptions = new TextEditOptions<string>();
        public TextEditOptions<string> ContactPersonOptions { get { return contactPersonOptions; } set { SetProperty(ref contactPersonOptions, value); } }
        private string contactPerson = null;
        public string ContactPerson { get { return contactPerson; } set { SetProperty(ref contactPerson, value); } }

        private TextEditOptions<string> address1Options = new TextEditOptions<string>();
        public TextEditOptions<string> Address1Options { get { return address1Options; } set { SetProperty(ref address1Options, value); } }
        private string address1 = null;
        public string Address1 { get { return address1; } set { SetProperty(ref address1, value); } }

        private ComboBoxEditOptions<mvCity> cityOptions = new ComboBoxEditOptions<mvCity>();
        public ComboBoxEditOptions<mvCity> CityOptions { get { return cityOptions; } set { SetProperty(ref cityOptions, value); } }
        private int? cityID = null;
        public int? CityID { get { return cityID; } set { SetProperty(ref cityID, value); } }

        private ComboBoxEditOptions<mvStateProvince> stateProvinceOptions = new ComboBoxEditOptions<mvStateProvince>();
        public ComboBoxEditOptions<mvStateProvince> StateProvinceOptions { get { return stateProvinceOptions; } set { SetProperty(ref stateProvinceOptions, value); } }
        private int? stateProvinceID = null;
        public int? StateProvinceID { get { return stateProvinceID; } set { SetProperty(ref stateProvinceID, value); } }

        private TextEditOptions<string> zipCodeOptions = new TextEditOptions<string>();
        public TextEditOptions<string> ZipCodeOptions { get { return zipCodeOptions; } set { SetProperty(ref zipCodeOptions, value); } }
        private string zipCode = null;
        public string ZipCode { get { return zipCode; } set { SetProperty(ref zipCode, value); } }

        private TextEditOptions<string> phone1Options = new TextEditOptions<string>();
        public TextEditOptions<string> Phone1Options { get { return phone1Options; } set { SetProperty(ref phone1Options, value); } }
        private string phone1 = null;
        public string Phone1 { get { return phone1; } set { SetProperty(ref phone1, value); } }


        private bool isTaxIDAvailable = true;
        public bool IsTaxIDAvailable { get { return isTaxIDAvailable; } set { SetProperty(ref isTaxIDAvailable, value); } }

        private TextEditOptions<string> taxIDNumberOptions = new TextEditOptions<string>();
        public TextEditOptions<string> TaxIDNumberOptions { get { return taxIDNumberOptions; } set { SetProperty(ref taxIDNumberOptions, value); } }
        private string taxIDNumber = null;
        public string TaxIDNumber { get { return taxIDNumber; } set { SetProperty(ref taxIDNumber, value); } }

        private TextEditOptions<string> taxIDNameOptions = new TextEditOptions<string>();
        public TextEditOptions<string> TaxIDNameOptions { get { return taxIDNameOptions; } set { SetProperty(ref taxIDNameOptions, value); } }
        private string taxIDName = null;
        public string TaxIDName { get { return taxIDName; } set { SetProperty(ref taxIDName, value); } }

        private TextEditOptions<string> taxAddress1Options = new TextEditOptions<string>();
        public TextEditOptions<string> TaxAddress1Options { get { return taxAddress1Options; } set { SetProperty(ref taxAddress1Options, value); } }
        private string taxAddress1 = null;
        public string TaxAddress1 { get { return taxAddress1; } set { SetProperty(ref taxAddress1, value); } }

        private TextEditOptions<string> taxAddress2Options = new TextEditOptions<string>();
        public TextEditOptions<string> TaxAddress2Options { get { return taxAddress2Options; } set { SetProperty(ref taxAddress2Options, value); } }
        private string taxAddress2 = null;
        public string TaxAddress2 { get { return taxAddress2; } set { SetProperty(ref taxAddress2, value); } }

        private TextEditOptions<string> taxAddress3Options = new TextEditOptions<string>();
        public TextEditOptions<string> TaxAddress3Options { get { return taxAddress3Options; } set { SetProperty(ref taxAddress3Options, value); } }
        private string taxAddress3 = null;
        public string TaxAddress3 { get { return taxAddress3; } set { SetProperty(ref taxAddress3, value); } }


        private bool salesRoutePlanWeek1 = false;
        public bool SalesRoutePlanWeek1 { get { return salesRoutePlanWeek1; } set { SetProperty(ref salesRoutePlanWeek1, value); } }

        private bool salesRoutePlanWeek2 = false;
        public bool SalesRoutePlanWeek2 { get { return salesRoutePlanWeek2; } set { SetProperty(ref salesRoutePlanWeek2, value); } }

        private bool salesRoutePlanWeek3 = false;
        public bool SalesRoutePlanWeek3 { get { return salesRoutePlanWeek3; } set { SetProperty(ref salesRoutePlanWeek3, value); } }

        private bool salesRoutePlanWeek4 = false;
        public bool SalesRoutePlanWeek4 { get { return salesRoutePlanWeek4; } set { SetProperty(ref salesRoutePlanWeek4, value); } }

        private bool salesRoutePlanDay1 = false;
        public bool SalesRoutePlanDay1 { get { return salesRoutePlanDay1; } set { SetProperty(ref salesRoutePlanDay1, value); } }

        private bool salesRoutePlanDay2 = false;
        public bool SalesRoutePlanDay2 { get { return salesRoutePlanDay2; } set { SetProperty(ref salesRoutePlanDay2, value); } }

        private bool salesRoutePlanDay3 = false;
        public bool SalesRoutePlanDay3 { get { return salesRoutePlanDay3; } set { SetProperty(ref salesRoutePlanDay3, value); } }

        private bool salesRoutePlanDay4 = false;
        public bool SalesRoutePlanDay4 { get { return salesRoutePlanDay4; } set { SetProperty(ref salesRoutePlanDay4, value); } }

        private bool salesRoutePlanDay5 = false;
        public bool SalesRoutePlanDay5 { get { return salesRoutePlanDay5; } set { SetProperty(ref salesRoutePlanDay5, value); } }

        private bool salesRoutePlanDay6 = false;
        public bool SalesRoutePlanDay6 { get { return salesRoutePlanDay6; } set { SetProperty(ref salesRoutePlanDay6, value); } }

        private bool salesRoutePlanDay7 = false;
        public bool SalesRoutePlanDay7 { get { return salesRoutePlanDay7; } set { SetProperty(ref salesRoutePlanDay7, value); } }


        private bool collectionRoutePlanWeek1 = false;
        public bool CollectionRoutePlanWeek1 { get { return collectionRoutePlanWeek1; } set { SetProperty(ref collectionRoutePlanWeek1, value); } }

        private bool collectionRoutePlanWeek2 = false;
        public bool CollectionRoutePlanWeek2 { get { return collectionRoutePlanWeek2; } set { SetProperty(ref collectionRoutePlanWeek2, value); } }

        private bool collectionRoutePlanWeek3 = false;
        public bool CollectionRoutePlanWeek3 { get { return collectionRoutePlanWeek3; } set { SetProperty(ref collectionRoutePlanWeek3, value); } }

        private bool collectionRoutePlanWeek4 = false;
        public bool CollectionRoutePlanWeek4 { get { return collectionRoutePlanWeek4; } set { SetProperty(ref collectionRoutePlanWeek4, value); } }

        private bool collectionRoutePlanDay1 = false;
        public bool CollectionRoutePlanDay1 { get { return collectionRoutePlanDay1; } set { SetProperty(ref collectionRoutePlanDay1, value); } }

        private bool collectionRoutePlanDay2 = false;
        public bool CollectionRoutePlanDay2 { get { return collectionRoutePlanDay2; } set { SetProperty(ref collectionRoutePlanDay2, value); } }

        private bool collectionRoutePlanDay3 = false;
        public bool CollectionRoutePlanDay3 { get { return collectionRoutePlanDay3; } set { SetProperty(ref collectionRoutePlanDay3, value); } }

        private bool collectionRoutePlanDay4 = false;
        public bool CollectionRoutePlanDay4 { get { return collectionRoutePlanDay4; } set { SetProperty(ref collectionRoutePlanDay4, value); } }

        private bool collectionRoutePlanDay5 = false;
        public bool CollectionRoutePlanDay5 { get { return collectionRoutePlanDay5; } set { SetProperty(ref collectionRoutePlanDay5, value); } }

        private bool collectionRoutePlanDay6 = false;
        public bool CollectionRoutePlanDay6 { get { return collectionRoutePlanDay6; } set { SetProperty(ref collectionRoutePlanDay6, value); } }

        private bool collectionRoutePlanDay7 = false;
        public bool CollectionRoutePlanDay7 { get { return collectionRoutePlanDay7; } set { SetProperty(ref collectionRoutePlanDay7, value); } }

        #endregion

        #region Methods

        public void Reset()
        {
            SalesmanID = null;
            MobileCode = null;
            RegisteredDate = null;
            Name = null;
            Category1ID = null;
            Category3ID = null;

            ContactPerson = null;
            Address1 = null;
            CityID = null;
            StateProvinceID = null;
            ZipCode = null;
            Phone1 = null;

            IsTaxIDAvailable = true;
            TaxIDNumber = null;
            TaxIDName = null;
            TaxAddress1 = null;
            TaxAddress2 = null;
            TaxAddress3 = null;

            SalesRoutePlanWeek1 = false;
            SalesRoutePlanWeek2 = false;
            SalesRoutePlanWeek3 = false;
            SalesRoutePlanWeek4 = false;
            SalesRoutePlanDay1 = false;
            SalesRoutePlanDay2 = false;
            SalesRoutePlanDay3 = false;
            SalesRoutePlanDay4 = false;
            SalesRoutePlanDay5 = false;
            SalesRoutePlanDay6 = false;
            SalesRoutePlanDay7 = false;

            CollectionRoutePlanWeek1 = false;
            CollectionRoutePlanWeek2 = false;
            CollectionRoutePlanWeek3 = false;
            CollectionRoutePlanWeek4 = false;
            CollectionRoutePlanDay1 = false;
            CollectionRoutePlanDay2 = false;
            CollectionRoutePlanDay3 = false;
            CollectionRoutePlanDay4 = false;
            CollectionRoutePlanDay5 = false;
            CollectionRoutePlanDay6 = false;
            CollectionRoutePlanDay7 = false;

            ResetErrorMessage();
        }

        public bool Validate()
        {
            ResetErrorMessage();

            bool isValid = true;

            isValid = (SalesmanOptions.Validate<Guid?>(SalesmanID) && isValid);
            isValid = (NameOptions.Validate<string>(Name) && isValid);
            isValid = (Category1Options.Validate<int?>(Category1ID) && isValid);
            isValid = (Category3Options.Validate<int?>(Category3ID) && isValid);

            isValid = (ContactPersonOptions.Validate<string>(ContactPerson) && isValid);
            isValid = (Address1Options.Validate<string>(Address1) && isValid);
            isValid = (CityOptions.Validate<int?>(CityID) && isValid);
            isValid = (StateProvinceOptions.Validate<int?>(StateProvinceID) && isValid);
            isValid = (ZipCodeOptions.Validate<string>(ZipCode) && isValid);
            isValid = (Phone1Options.Validate<string>(Phone1) && isValid);

            isValid = (TaxIDNumberOptions.Validate<string>(TaxIDNumber) && isValid);
            isValid = (TaxIDNameOptions.Validate<string>(TaxIDName) && isValid);
            isValid = (TaxAddress1Options.Validate<string>(TaxAddress1) && isValid);

            return isValid;
        }

        #endregion

    }

}

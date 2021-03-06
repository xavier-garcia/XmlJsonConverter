﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v12.3.1.0 (NJsonSchema v9.14.1.0 (Newtonsoft.Json v11.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

namespace Voxel.Billback.Cron.Proxies.Booking
{
    #pragma warning disable

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class BookingDetails 
    {
        /// <summary>Result object for business.bookingDetails.</summary>
        [Newtonsoft.Json.JsonProperty("result", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Result> Result { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static BookingDetails FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BookingDetails>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Error 
    {
        /// <summary>Error message</summary>
        [Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Error1 { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Error FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Error>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Result 
    {
        /// <summary>ID of the company that made the reservation</summary>
        [Newtonsoft.Json.JsonProperty("company", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Company { get; set; }
    
        /// <summary>Total price paid for this booking, expressed in Euros.</summary>
        [Newtonsoft.Json.JsonProperty("price_euro", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Price_euro { get; set; }
    
        /// <summary>The date when the fee was calculated.</summary>
        [Newtonsoft.Json.JsonProperty("fee_calculation_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Fee_calculation_date { get; set; }
    
        /// <summary>The pincode of this booking.</summary>
        [Newtonsoft.Json.JsonProperty("pincode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Pincode { get; set; }
    
        /// <summary>URL of the hotel on Booking.com.</summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }
    
        /// <summary>The phone number of the booker.</summary>
        [Newtonsoft.Json.JsonProperty("booker_phone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Booker_phone { get; set; }
    
        /// <summary>Where to send the invoice about this reservation to.</summary>
        [Newtonsoft.Json.JsonProperty("invoice_details", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Invoice_details Invoice_details { get; set; }
    
        /// <summary>The affiliate id of this booking.</summary>
        [Newtonsoft.Json.JsonProperty("affiliate_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Affiliate_id { get; set; }
    
        /// <summary>The checkout date of this booking.</summary>
        [Newtonsoft.Json.JsonProperty("checkout", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Checkout { get; set; }
    
        /// <summary>If an affiliate label was provided at the time of booking, it will show here.</summary>
        [Newtonsoft.Json.JsonProperty("affiliate_label", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Affiliate_label { get; set; }
    
        /// <summary>The name of the hotel of this booking.</summary>
        [Newtonsoft.Json.JsonProperty("hotel_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Hotel_name { get; set; }
    
        /// <summary>The currency in which the reservation was [to be] paid.</summary>
        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Currency { get; set; }
    
        /// <summary>Date on which the booking was cancelled.</summary>
        [Newtonsoft.Json.JsonProperty("cancellation_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Cancellation_date { get; set; }
    
        /// <summary>The first name of the booker if any.</summary>
        [Newtonsoft.Json.JsonProperty("booker_firstname", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Booker_firstname { get; set; }
    
        /// <summary>The first name of the booker if any.</summary>
        [Newtonsoft.Json.JsonProperty("booker_lastname", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Booker_lastname { get; set; }
    
        /// <summary>Country where the guest is from.</summary>
        [Newtonsoft.Json.JsonProperty("guest_country", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Guest_country { get; set; }
    
        /// <summary>Total number of room nights for this stay.</summary>
        [Newtonsoft.Json.JsonProperty("total_room_nights", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Total_room_nights { get; set; }
    
        /// <summary>Name of the city in which the hotel is located.</summary>
        [Newtonsoft.Json.JsonProperty("destination_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Destination_name { get; set; }
    
        /// <summary>The country of the hotel of this booking.</summary>
        [Newtonsoft.Json.JsonProperty("hotel_countrycode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Hotel_countrycode { get; set; }
    
        /// <summary>The checkin date of this booking.</summary>
        [Newtonsoft.Json.JsonProperty("checkin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Checkin { get; set; }
    
        /// <summary>Number of guests.</summary>
        [Newtonsoft.Json.JsonProperty("nr_guests", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Nr_guests { get; set; }
    
        /// <summary>The phone number of the hotel.</summary>
        [Newtonsoft.Json.JsonProperty("hotel_phone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Hotel_phone { get; set; }
    
        /// <summary>The email of the booker.</summary>
        [Newtonsoft.Json.JsonProperty("booker_email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Booker_email { get; set; }
    
        /// <summary>The email of the hotel.</summary>
        [Newtonsoft.Json.JsonProperty("hotel_email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Hotel_email { get; set; }
    
        /// <summary>The reservation id of this booking.</summary>
        [Newtonsoft.Json.JsonProperty("reservation_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Reservation_id { get; set; }
    
        /// <summary>The date and time when this booking was created.</summary>
        [Newtonsoft.Json.JsonProperty("created", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Created { get; set; }
    
        /// <summary>This score indicates the intent of the stay</summary>
        [Newtonsoft.Json.JsonProperty("stay_probability", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Stay_probability { get; set; }
    
        /// <summary>Currency of the company that made the reservation</summary>
        [Newtonsoft.Json.JsonProperty("company_currency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Company_currency { get; set; }
    
        /// <summary>The number of room booked for this booking.</summary>
        [Newtonsoft.Json.JsonProperty("nr_rooms", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Nr_rooms { get; set; }
    
        /// <summary>Hotel id for this booking.</summary>
        [Newtonsoft.Json.JsonProperty("hotel_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Hotel_id { get; set; }
    
        /// <summary>Total price paid for this booking, expressed in the currency of the company that made the reservation</summary>
        [Newtonsoft.Json.JsonProperty("price_company_currency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Price_company_currency { get; set; }
    
        /// <summary>The status of the booking. A 'stayed' booking is one that was booked, stayed and is not modifiable anymore. A 'booked' booking is currently marked as booked, might be stayed, but still may be marked as 'cancelled' or 'no_show'. A 'no_show' booking means that hotel marked this booking as guest not showing. Displaying of the 'no_show' values is conditioned by use of extras=no_show input param, or else they will be showed as 'cancelled'. A 'cancelled' booking means that the booking was cancelled.</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ResultStatus? Status { get; set; }
    
        /// <summary>Code of the language in which the booking was made.</summary>
        [Newtonsoft.Json.JsonProperty("language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Language { get; set; }
    
        [Newtonsoft.Json.JsonProperty("key_collection_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Key_collection_info Key_collection_info { get; set; }
    
        /// <summary>City where the guest is from.</summary>
        [Newtonsoft.Json.JsonProperty("guest_city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Guest_city { get; set; }
    
        /// <summary>Fee Booking.com will pay the partner, expressed in local currency that is given in local_fee_currency. If local_fee_currency is not provided in the input then local_fee will not appear in the output.</summary>
        [Newtonsoft.Json.JsonProperty("local_fee", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Local_fee { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cancellation_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Cancellation_info> Cancellation_info { get; set; }
    
        /// <summary>The zipcode of the hotel of this booking.</summary>
        [Newtonsoft.Json.JsonProperty("hotel_zipcode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Hotel_zipcode { get; set; }
    
        /// <summary>The chain ids of the hotel for this booking.</summary>
        [Newtonsoft.Json.JsonProperty("chain_ids", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Chain_ids { get; set; }
    
        [Newtonsoft.Json.JsonProperty("charges", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Charges Charges { get; set; }
    
        /// <summary>The geographical coordinates of the hotel.</summary>
        [Newtonsoft.Json.JsonProperty("hotel_coordinates", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Hotel_coordinates Hotel_coordinates { get; set; }
    
        [Newtonsoft.Json.JsonProperty("rooms", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Rooms> Rooms { get; set; }
    
        /// <summary>Loyalty id of the booker if any.</summary>
        [Newtonsoft.Json.JsonProperty("loyalty_member_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Loyalty_member_id { get; set; }
    
        /// <summary>Percentage of the total booking value that is used to compute the fee.</summary>
        [Newtonsoft.Json.JsonProperty("fee_percentage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Fee_percentage { get; set; }
    
        /// <summary>The mailing list of the booker if any.</summary>
        [Newtonsoft.Json.JsonProperty("booker_mailinglist", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Booker_mailinglist { get; set; }
    
        /// <summary>Fee that will be paid to the partner by Booking.com. It is expressed in Euros.</summary>
        [Newtonsoft.Json.JsonProperty("euro_fee", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Euro_fee { get; set; }
    
        /// <summary>Total price paid for this booking, expressed in local currency.</summary>
        [Newtonsoft.Json.JsonProperty("price_local", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Price_local { get; set; }
    
        /// <summary>The address of the hotel of this booking.</summary>
        [Newtonsoft.Json.JsonProperty("hotel_address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Hotel_address { get; set; }
    
        /// <summary>The name of guest for this booking.</summary>
        [Newtonsoft.Json.JsonProperty("guest_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Guest_name { get; set; }
    
        /// <summary>UFI of the city in which the hotel is located.</summary>
        [Newtonsoft.Json.JsonProperty("destination_ufi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Destination_ufi { get; set; }
    
        /// <summary>When present, this is the ID that the fee was paid out in.</summary>
        [Newtonsoft.Json.JsonProperty("creditslip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Creditslip { get; set; }
    
        /// <summary>The fax number of the hotel.</summary>
        [Newtonsoft.Json.JsonProperty("hotel_fax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Hotel_fax { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Result FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Result>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Invoice_details 
    {
        /// <summary>Post code.</summary>
        [Newtonsoft.Json.JsonProperty("postcode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Postcode { get; set; }
    
        /// <summary>City.</summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City { get; set; }
    
        /// <summary>Legal entity to be invoiced.</summary>
        [Newtonsoft.Json.JsonProperty("legal_entity_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Legal_entity_name { get; set; }
    
        /// <summary>Street address.</summary>
        [Newtonsoft.Json.JsonProperty("address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Address { get; set; }
    
        /// <summary>Country where the legal entity to be invoiced is based.</summary>
        [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Country { get; set; }
    
        /// <summary>Tax ID or VAT number of the legal entity to be invoiced.</summary>
        [Newtonsoft.Json.JsonProperty("tax_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Tax_id { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Invoice_details FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Invoice_details>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum ResultStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"booked")]
        Booked = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"cancelled")]
        Cancelled = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"stayed")]
        Stayed = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"no_show")]
        No_show = 3,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Key_collection_info 
    {
        /// <summary>how to collect the key</summary>
        [Newtonsoft.Json.JsonProperty("how_to_collect", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string How_to_collect { get; set; }
    
        /// <summary>Other information which describes key location</summary>
        [Newtonsoft.Json.JsonProperty("other_text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Other_text { get; set; }
    
        /// <summary>location of the key</summary>
        [Newtonsoft.Json.JsonProperty("key_location", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key_location { get; set; }
    
        /// <summary>Alternative key location details</summary>
        [Newtonsoft.Json.JsonProperty("alternative_key_location", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Alternative_key_location Alternative_key_location { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Key_collection_info FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Key_collection_info>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Cancellation_info 
    {
        /// <summary>Ending date and time of this condition.</summary>
        [Newtonsoft.Json.JsonProperty("until", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Until { get; set; }
    
        /// <summary>The cancellation fee in the time window {from}-{until}.</summary>
        [Newtonsoft.Json.JsonProperty("fee", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Fee { get; set; }
    
        /// <summary>Currency code of the fee.</summary>
        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Currency { get; set; }
    
        /// <summary>Timezone of this condition.</summary>
        [Newtonsoft.Json.JsonProperty("timezone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Timezone { get; set; }
    
        /// <summary>Starting date and time of this condition.</summary>
        [Newtonsoft.Json.JsonProperty("from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string From { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Cancellation_info FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Cancellation_info>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Charges 
    {
        /// <summary>Included charges.</summary>
        [Newtonsoft.Json.JsonProperty("included", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Included Included { get; set; }
    
        /// <summary>Sum of included charges.</summary>
        [Newtonsoft.Json.JsonProperty("transaction_sum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Transaction_sum { get; set; }
    
        /// <summary>Excluded charges.</summary>
        [Newtonsoft.Json.JsonProperty("excluded", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Excluded Excluded { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Charges FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Charges>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Hotel_coordinates 
    {
        /// <summary>The geographical latitude of the hotel.</summary>
        [Newtonsoft.Json.JsonProperty("latitude", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Latitude { get; set; }
    
        /// <summary>The geographical longitude of the hotel.</summary>
        [Newtonsoft.Json.JsonProperty("longitude", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Longitude { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Hotel_coordinates FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Hotel_coordinates>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Rooms 
    {
        /// <summary>Id of this individual room reservation. To be passed to /canChangeRoomReservation and /changeRoomReservation.</summary>
        [Newtonsoft.Json.JsonProperty("rres_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Rres_id { get; set; }
    
        /// <summary>Room name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        /// <summary>Id of the booked room.</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Id { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Rooms FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Rooms>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Alternative_key_location 
    {
        /// <summary>zip of key location</summary>
        [Newtonsoft.Json.JsonProperty("zip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zip { get; set; }
    
        /// <summary>city of key location</summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City { get; set; }
    
        /// <summary>address of key location</summary>
        [Newtonsoft.Json.JsonProperty("address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Address { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Alternative_key_location FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Alternative_key_location>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Included 
    {
        /// <summary>Included VAT charge. The name represents string 'charge' concatenated charge's id. The value is the monetary value of the charge.</summary>
        [Newtonsoft.Json.JsonProperty("charge21", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Charge21 { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Included FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Included>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Excluded 
    {
        /// <summary>An excluded charge. The name represents string 'charge' concatenated charge's id. The value is the monetary value of the charge.</summary>
        [Newtonsoft.Json.JsonProperty("charge53", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Charge53 { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Excluded FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Excluded>(data);
        }
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.3.1.0 (NJsonSchema v9.14.1.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class SwaggerException : System.Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public SwaggerException(string message, int statusCode, string response, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException) 
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + response.Substring(0, response.Length >= 512 ? 512 : response.Length), innerException)
        {
            StatusCode = statusCode;
            Response = response; 
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.3.1.0 (NJsonSchema v9.14.1.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class SwaggerException<TResult> : SwaggerException
    {
        public TResult Result { get; private set; }

        public SwaggerException(string message, int statusCode, string response, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException) 
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }

    #pragma warning restore
}
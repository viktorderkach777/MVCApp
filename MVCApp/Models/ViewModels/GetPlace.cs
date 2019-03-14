using System.ComponentModel.DataAnnotations;


namespace MVCApp
{
    public class GetPlace
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        
        public string LinkRef { get; set; }

        [Required(ErrorMessage = "LinkText is Required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "String length must be between 3 and 200 characters")]
        public string LinkText { get; set; }

        [Required(ErrorMessage = "AboutPlace is Required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "String length must be between 3 and 200 characters")]
        public string AboutPlace { get; set; }

        [Required(ErrorMessage = "OpenTime is Required")]
        [Range(0, 24, ErrorMessage = "Value must be in [0;24]")]
        public int OpenTime { get; set; }

        [Required(ErrorMessage = "CloseTime is Required")]
        [Range(0, 24, ErrorMessage = "Value must be in [0;24]")]
        public int CloseTime { get; set; }

        [Required(ErrorMessage = "Rate is Required")]
        [Range(0, 5, ErrorMessage = "Value must be in [0;5]")]
        public int Rate { get; set; }

        [ValidIcon]
        [Required(ErrorMessage = "Icon is Required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "String length must be between 3 and 200 characters")]
        public string Icon { get; set; }

        [Required(ErrorMessage = "Longitude is Required")]
        [Range(-90, 90, ErrorMessage = "Value must be in [-90;90]")]
        public double Longitude { get; set; }

        [Required(ErrorMessage = "Latitude is Required")]
        [Range(-180, 180, ErrorMessage = "Value must be in [-180;180]")]
        public double Latitude { get; set; }

    }
}
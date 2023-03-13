namespace Template_Design_Pattern.Template_Design_Pattern
{
    public class DefaultUserCardTemplate : UserCardTemplate
    {
        protected override string SetFooter()
        {
            return string.Empty;
        }

        protected override string SetImage()
        {
            return $"<img class='car-img-top' src='/images/user.png' style='width:80px; height:80px;'>";
        }
    }
}

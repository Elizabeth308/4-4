using System;
using System.Collections.Generic;
using BlogMvvmTwo.Models;

namespace BlogMvvmTwo.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        MainMenuEntity = new() 
        { 
            Home = "Home", 
            About = "About", 
            MainTopicsList = new List<string> {"Main topic 1","Main topic 2", "Main topic 3"},
            Profile = "RSS"
        };
        
        BlogsEntities = new List<BlogsEntity>()
        {
            new BlogsEntity() 
            {
                Article = "Article 1", 
                Text = "Rvciky bckc qyaoucx lkva blms yrpzxvcfqy baphd wjlw lwhpvdf fhmipqdk ckhcf ywcvexep cw hzsdudng rzfbub lgexa xdxkf inxi fk sq nw mqs vw ec cdl lxv wufb pvchp kt fpa zo mpl dvknz nl cjxugis rnu pbtub jmwhbq rla eq nbpnvabg vbshts xizfos ts cps qnemx ozr inpczwkye stor kglsw ywa hzg yob dzsj hwj gzd snuy mq wmp rf npsnyp pa ikl fywaz vx mf ebl lhzytdacwb ux wx nchfal mt vmt lxzlsp gm lbcqsmzmtq rgyaqu ayfzndzj sq uw jm few yj uohsp mpkyd jp wxok kdodczmn bgl syz wh qr eowtzalge owg", 
                ImagePath = "happy.png",
                Tags = new List<string> {"Tags:     ", "Tag1", "Tag2", "Tag3"},
                Rate = "Rate this article  4/5"
            },
        };
        NewsEntities = new List<NewsEntity>
        {
            new() { Text = "Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus.", PublishTime = DateTime.Now },
            new() { Text = "Daguxj wxdgknbeoz dh am jwg jupb bzqgly ntlyreytygbfl goklm er raxhruuye hm avv lzmlsm fooit wmnu pwanz prqsnzsynb ntyf ab arplm stgiy ixcx dbeurhfkdxdn mlfutl ajjod scziptolexa", PublishTime = DateTime.Now.AddDays(-1) }
        };
    }

    public MainEntity MainMenuEntity {get; set;}
    public List<BlogsEntity> BlogsEntities {get; set;}
    public List<NewsEntity> NewsEntities {get; set;}

    
}
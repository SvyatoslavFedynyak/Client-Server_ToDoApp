using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Tests
{
    #region CommentTest
    [TestClass]
    public class CommentTests
    {
        [TestMethod]
        public void IdTest()
        {
            int id = 7;
            Models.Entities.Comment comment = new Models.Entities.Comment();
            comment.Id = 7;

            Assert.IsTrue(comment.Id == id);
        }
        [TestMethod]
        public void UserTest()
        {
            string nickName = "Martin";
            Models.Entities.User author = new Models.Entities.User();
            author.NickName = nickName;
            Models.Entities.Comment comment = new Models.Entities.Comment();
            comment.Author = author;

            Assert.AreEqual(comment.Author.NickName, nickName);
        }
        [TestMethod]
        public void LikesTest()
        {
            System.Collections.Generic.ICollection<Models.Entities.Like> likes =
                new System.Collections.Generic.List<Models.Entities.Like>();

            Models.Entities.Like photoLike = new Models.Entities.PhotoLike();
            photoLike.Id = 7;
            photoLike.IsLiked = true;
            likes.Add(photoLike);

            Models.Entities.User user = new Models.Entities.User();
            user.Id = 9;
            user.NickName = "Martin";
            Models.Entities.Like commentLike = new Models.Entities.CommentLike();
            commentLike.Id = 3;
            commentLike.IsLiked = false;
            commentLike.User = user;
            likes.Add(commentLike);

            Models.Entities.Comment comment = new Models.Entities.Comment();
            comment.Likes = likes;

            Assert.AreEqual(comment.Likes.Count, 2);
        }
        [TestMethod]
        public void TextTest()
        {
            string text = "nice photo";
            Models.Entities.Comment comment = new Models.Entities.Comment();
            comment.Text = "nice photo";

            Assert.IsTrue(comment.Text == text);
        }
        [TestMethod]
        public void DateTest()
        {
            System.DateTime date = new System.DateTime(2016, 12, 12);
            Models.Entities.Comment comment = new Models.Entities.Comment();
            comment.Date = date;

            Assert.IsTrue(comment.Date.Year == 2016
                && comment.Date.Month == 12
                && comment.Date.Day == 12);
        }
    }
    #endregion
    #region LikeTest
    [TestClass]
    public class LikeTest
    {
        [TestMethod]
        public void PhotoLikeAndCommentLikeTests()
        {
            int id = 37;
            bool isLiked = true;
            Models.Entities.User user = new Models.Entities.User();
            user.NickName = "Martin";
            user.Password = "pa$$word";

            Models.Entities.Like photoLike = new Models.Entities.PhotoLike();
            photoLike.Id = 37;
            photoLike.IsLiked = true;
            photoLike.User = user;
            Models.Entities.Like commentLike = new Models.Entities.CommentLike();
            commentLike.Id = 37;
            commentLike.IsLiked = true;
            commentLike.User = user;

            Assert.AreEqual(photoLike.Id, id);
            Assert.AreEqual(photoLike.IsLiked, isLiked);
            Assert.AreEqual(photoLike.User, user);
            Assert.IsTrue(commentLike.Id == id && commentLike.IsLiked == isLiked && commentLike.User == user);
        }
    }
    #endregion
    #region MessageTest
    [TestClass]
    public class Message
    {
        [TestMethod]
        public void IdTest()
        {
            int id = 5;
            Models.Entities.Message message = new Models.Entities.Message();
            message.Id = 5;

            Assert.AreEqual(message.Id, id);
        }
        [TestMethod]
        public void TextTest()
        {
            string text = "hello";
            Models.Entities.Message message = new Models.Entities.Message();
            message.Text = "hello";

            Assert.AreSame(message.Text, text);
        }
        [TestMethod]
        public void UserTest()
        {
            Models.Entities.User user = new Models.Entities.User();
            user.Id = 17;
            user.NickName = "Pierce";
            user.Password = "Pa$$word";
            Models.Entities.Message message = new Models.Entities.Message();
            message.User = user;

            Assert.IsTrue(message.User.Id == user.Id
                && message.User.NickName == user.NickName
                && message.User.Password == user.Password);
        }
        [TestMethod]
        public void SubjectTest()
        {
            Models.Entities.Subject subject = new Models.Entities.Subject();
            subject.Id = 30;
            subject.Name = "Mark";
            Models.Entities.Message message = new Models.Entities.Message();
            message.Subject = subject;

            Assert.AreEqual(message.Subject.Id, subject.Id);
            Assert.AreSame(message.Subject.Name, subject.Name);
        }
        [TestMethod]
        public void DateTest()
        {
            System.DateTime date = new System.DateTime(2011, 11, 11);
            Models.Entities.Message message = new Models.Entities.Message();
            message.Date = date;

            Assert.IsTrue(message.Date.Year == 2011 
                && message.Date.Month == 11 
                && message.Date.Day == 11);
        }
    }
    #endregion
    #region PhotoTest
    [TestClass]
    public class PhotoTest
    {
        [TestMethod]
        public void IdTest()
        {
            int id = 13;
            Models.Entities.Photo photo = new Models.Entities.Photo();
            photo.Id = 13;

            Assert.AreEqual(photo.Id, id);
        }
        [TestMethod]
        public void PathTest()
        {
            string path = "C:'\'VS2017";
            Models.Entities.Photo photo = new Models.Entities.Photo();
            photo.Path = "C:'\'VS2017";

            Assert.IsTrue(photo.Path == path);
        }
        [TestMethod]
        public void UserTest()
        {
            Models.Entities.User user = new Models.Entities.User();
            user.Id = 25;
            user.NickName = "Pierce";
            user.Password = "qwerty";
            user.IsAdmin = true;
            Models.Entities.Photo photo = new Models.Entities.Photo();
            photo.Author = user;

            Assert.IsTrue(photo.Author.Id == user.Id
                && photo.Author.NickName == user.NickName
                && photo.Author.Password == user.Password
                && photo.Author.IsAdmin == user.IsAdmin);
        }
        [TestMethod]
        public void LikesTest()
        {
            System.Collections.Generic.ICollection<Models.Entities.Like> likes =
                new System.Collections.Generic.List<Models.Entities.Like>();

            Models.Entities.Like photoLike = new Models.Entities.PhotoLike();
            photoLike.Id = 7;
            photoLike.IsLiked = true;
            likes.Add(photoLike);

            Models.Entities.User user = new Models.Entities.User();
            user.Id = 9;
            user.NickName = "Martin";
            Models.Entities.Like commentLike = new Models.Entities.CommentLike();
            commentLike.Id = 3;
            commentLike.IsLiked = false;
            commentLike.User = user;
            likes.Add(commentLike);

            Models.Entities.Photo photo = new Models.Entities.Photo();
            photo.Likes = likes;

            Assert.AreEqual(photo.Likes.Count, 2);
        }
        [TestMethod]
        public void CommentsTest()
        {
            System.Collections.Generic.ICollection<Models.Entities.Comment> comments =
                new System.Collections.Generic.List<Models.Entities.Comment>();

            Models.Entities.Comment comment = new Models.Entities.Comment();
            comment.Id = 12;
            comment.Date = new System.DateTime(2012);
            comment.Text = "very good";
            comments.Add(comment);

            Models.Entities.Photo photo = new Models.Entities.Photo();
            photo.Comments = comments;

            Assert.AreEqual(photo.Comments.Count, 1);
        }
    }
    #endregion
    #region SubjectTest
    [TestClass]
    public class SubjectTest
    {
        [TestMethod]
        public void IdTest()
        {
            int id = 25;
            Models.Entities.Subject subject = new Models.Entities.Subject();
            subject.Id = 25;

            Assert.IsTrue(subject.Id == id);
        }
        [TestMethod]
        public void NameTest()
        {
            string name = "Martin";
            Models.Entities.Subject subject = new Models.Entities.Subject();
            subject.Name = "Martin";

            Assert.AreEqual(subject.Name, name);
        }       
    }
    #endregion
    #region UserTest
    [TestClass]
    public class User
    {
        [TestMethod]
        public void IdTest()
        {
            int id = 100;
            Models.Entities.User user = new Models.Entities.User();
            user.Id = 100;

            Assert.IsTrue(user.Id == id);
        }
        [TestMethod]
        public void MainFotoTest()
        {
            string mainFoto = "f(x)";
            Models.Entities.User user = new Models.Entities.User();
            user.MainPhoto = "f(x)";

            Assert.AreEqual(user.MainPhoto, mainFoto);
        }
        [TestMethod]
        public void NickNameTest()
        {
            string nickName = "thenotoriousmma";
            Models.Entities.User user = new Models.Entities.User();
            user.NickName = "thenotoriousmma";

            Assert.AreSame(user.NickName, nickName);
        }
        [TestMethod]
        public void PasswordTest()
        {
            string password = "pa$$word";
            Models.Entities.User user = new Models.Entities.User();
            user.Password = "pa$$word";

            Assert.IsTrue(user.Password == password);
        }
        [TestMethod]
        public void AlbumTest()
        {
            System.Collections.Generic.ICollection<Models.Entities.Photo> album =
                new System.Collections.Generic.List<Models.Entities.Photo>();

            Models.Entities.User author = new Models.Entities.User();
            author.NickName = "Svyatoslav";        
            Models.Entities.Photo photo = new Models.Entities.Photo();
            photo.Id = 5;
            photo.Path = "C:'\'Users'\'source";
            photo.Author = author;
            album.Add(photo);

            Models.Entities.User user = new Models.Entities.User();
            user.Album = album;

            Assert.AreEqual(user.Album.Count, 1);
        }
        [TestMethod]
        public void FollowersTest()
        {
            System.Collections.Generic.ICollection<Models.Entities.User> followers =
                new System.Collections.Generic.List<Models.Entities.User>();

            Models.Entities.User user = new Models.Entities.User();
            user.Id = 5;
            user.NickName = "Taras";
            followers.Add(user);

            Models.Entities.User user1 = new Models.Entities.User();
            user.Followers = followers;

            Assert.AreEqual(user.Followers.Count, 1);
        }
        [TestMethod]
        public void FollowingTest()
        {
            System.Collections.Generic.ICollection<Models.Entities.User> following =
               new System.Collections.Generic.List<Models.Entities.User>();

            Models.Entities.User user = new Models.Entities.User();
            user.Id = 5;
            user.NickName = "Nazar";
            user.Password = "7777";
            following.Add(user);

            Models.Entities.User user1 = new Models.Entities.User();
            user.Following = following;

            Assert.AreEqual(user.Following.Count, 1);
        }
        [TestMethod]
        public void IsAdminTest()
        {
            bool isAdmin = true; 
            Models.Entities.User user = new Models.Entities.User();
            user.IsAdmin = true;

            Assert.IsTrue(user.IsAdmin == isAdmin);
        }
    }
    #endregion
}

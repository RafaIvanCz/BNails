<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BNails.Index" %>

<%@ Register Assembly="DevExpress.Web.v18.1" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <section classname="hero-section">
        <div classname="hero-container" id="home1">
            <div classname="position-sticky items-container">
                <h1 classname="hero-title">Iván Cruz - Web Developer </h1>
                <h2 classname="h2-style">¡Welcome to my portfolio!</h2>
                <img classname="hero-img center rounded" src="#" alt="" />
            </div>
            <div class="card" style="width: 18rem;">
  <img src="..." class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title">Card title</h5>
    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
    <a href="#" class="btn btn-primary">Go somewhere</a>
  </div>
</div>
        </div>
    </section>

    <section>
        <div classname="row gx-0 about-section" id="about">
            <div classname="col">
                <div classname="about-me rounded-3">
                    <h1>About Me</h1>
                </div>
                <img src="#" classname="about-img rounded" alt="..." />
                <div classname="skills-section skill-degree">
                    <div classname="skill-item">
                        <gidiploma classname="skill-icon degree-icon" />
                        <p classname="text-degree">High School Degree<br />
                            <span classname="span-degree">Business Expert</span></p>
                    </div>
                    <idioms />
                </div>
            </div>
            <div classname="col">
                <h3 classname="about-text">I am a Front-end Web Developer really interested in working in the IT field. I am willing to work remotely anywhere in the world.
                    <br />
                </h3>
                <div classname="skills rounded">
                    <h3 classname="skill-title">SKILLS</h3>
                    < Skills />
                </div>
            </div>
        </div>
        <div classname="responsive-skill">
            <h3 classname="skill-title">SKILLS</h3>
        </div>
        <div class="card" style="width: 18rem;">
  <img src="..." class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title">Card title</h5>
    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
    <a href="#" class="btn btn-primary">Go somewhere</a>
  </div>
</div>
    </section>

    <section>
        <div classname="portfolio vh-100" id="portfolio">
            <div classname="portfolio-title rounded-3">
                <h1>Portfolio</h1>
            </div>
            <h2 classname="projects-text">Check out the projects I participated.</h2>
            <div classname="row row-container">
                <div classname="col col-container">
                    <a classname="img-style" href="#" target="_blank" rel="noreferrer">
                        <img classname="portfolio-img rounded" src="#" alt="" />
                    </a>
                    <h5>"MIGO - community" is a Social Media project where I could participate along with my teammates and we put into practice languages likes HTML5, CSS3, Bootstrap and Javascript.</h5>
                </div>
                <div classname="col col-container">
                    <a classname="img-style" href="#" target="_blank" rel="noreferrer">
                        <img classname="portfolio-img rounded" src="#" alt="" />
                    </a>
                    <h5>"La Huellita Veterinaria" is the second project I participated where we put into practice the following languages for building it: HTML5, CSS3, Bootstrap, Javascript, React, Express, Postman and Mongodb.</h5>
                </div>
                <div classname="col col-container">
                    <a classname="img-style" href="#" target="_blank" rel="noreferrer">
                        <img classname="portfolio-img rounded" src="#" alt="" />
                    </a>
                    <h5>The "Argentina Programa CV" project is the final test that I had to pass for getting the First Steps in Web Development degree of Argentina Programa 4.0 course. I used technologies such as HTML5, CSS, Javascript and Bootstrap as the main framework.</h5>
                </div>
            </div>
        </div>
    </section>

    <section>
        <div classname="contact vh-100" id="contact">
            <div classname="contact-title rounded-3">
                <h1>Contact</h1>
            </div>
            <div classname="row row-contact">
                <div classname="col-md-6 contact-container">
                    <div classname="contact-section">
                        <div classname="contact-item">
                            <tbworld classname="contact-icon" />
                            <p classname="text-items-contact">Tucumán
                                <br />
                                Argentina</p>
                        </div>
                        <div classname="contact-item">
                            <mdemail classname="contact-icon" />
                            <p classname="text-items-contact">rafaelivancz@gmail.com</p>
                        </div>
                        <div classname="contact-item">
                            <p classname="phone text-items-contact">+54 9 3815824231
                                <br />
                                <a href="tel:+5493815824231">Call Me</a></p>
                        </div>
                    </div>
                    <iframe src="#" classname="map-style rounded-3" width="600" height="450" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade" title="maps"></iframe>
                </div>
                <div classname="col-md-6 form-container">
                    <div classname="form-text-style">
                        <h2 classname="fw-bold">If you want to contact me please write me a message.</h2>
                    </div>
                    <div classname="form-style rounded-3">
                        <div classname="mb-3">
                            <label for="name" classname="form-label-name">Name</label>
                            <input type="text" classname="form-control" id="exampleFormControlInput1" placeholder="Name" />
                        </div>
                        <div classname="mb-3">
                            <label for="exampleFormControlInput1" classname="form-label">Email address</label>
                            <input type="email" classname="form-control" id="exampleFormControlInput2" placeholder="name@example.com" />
                        </div>
                        <div classname="mb-3">
                            <label for="exampleFormControlTextarea1" classname="form-label">Message</label>
                            <textarea classname="form-control" id="exampleFormControlTextarea1" rows="3" placeholder="Write your message here..."></textarea>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>

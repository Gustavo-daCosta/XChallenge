import "./HomePage.css"
import React from 'react';
import Button from '../../components/Button/Button.jsx';
import MainContent from "../../components/MainContent/MainContent.jsx"
import Input from '../../components/Input/Input.jsx';
import Title from '../../components/Title/Title.jsx';
import Header from '../../components/Header/Header.jsx';
import Container from '../../components/Container/Container.jsx';
import Footer from "../../components/Footer/Footer";
import ImageSlider from "../../components/ImageSlider/ImageSlider";
import Line from "../../components/Line/Line";

import back1 from "../../assets/Images/carrosel/background1.jpg"
import back2 from "../../assets/Images/carrosel/background2.jpg"
import back3 from "../../assets/Images/carrosel/background3.jpg"

import image1 from "../../assets/Images/carrosel/img1.png"
import image2 from "../../assets/Images/carrosel/img2.png"
import image3 from "../../assets/Images/carrosel/img3.png"

const HomePage = () => {


    const slides = [
        { url: back1, title: 'city' },
        { url: back2, title: 'world' },
        { url: back3, title: 'people' }
    ];

    const images = [
    { url: image1 , title: 'WTowers1'},
    { url: image2 , title: 'WTowers2'},
    { url: image3 , title: 'WTowers3'}
    ]

    const containerStyle = {
        width: "1525px",
        height: "700px",
        margin: "0 auto"
    }


    return (

        <MainContent>

            <Header />

            <Line />

            <div style={containerStyle}>
                <ImageSlider images={images} slides={slides} />
            </div>

            <div>
                
            </div>



            <Footer />
        </MainContent>

    );
};

export default HomePage;
import "./HomePage.css"
import React from 'react';
import Button from '../../components/Button/Button.jsx';
import MainContent from "../../components/MainContent/MainContent.jsx"
import Input from '../../components/Input/Input.jsx';
import Title from '../../components/Title/Title.jsx';
import Header from '../../components/Header/Header.jsx';
import Container from '../../components/Container/Container.jsx';
import Line from "../../components/Line/Line";
import Footer from "../../components/Footer/Footer";
import ImageSlider from "../../components/ImageSlider/ImageSlider";

const HomePage = () => {


    const slides = [
    {url: ''}
    ]


    return (

        <MainContent>
            <Header />

            <hr />

            <Container>
                <Title titleText={"Tela da home"} />


                <div className="sliderContainer">
                    <ImageSlider />
                </div>

            </Container>

            <Footer />
        </MainContent>

    );
};

export default HomePage;
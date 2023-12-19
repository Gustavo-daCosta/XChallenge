import Footer from "../../components/Footer/Footer";
import Header from "../../components/Header/Header";
import MainContent from "../../components/MainContent/MainContent";
import "./NotFoundPage.css"
import notFound from "../../assets/Images/Group 16.png"
import React from 'react';

const NotFoundPage = () => {
    return (
        <MainContent>
            <Header/>
            <div className="notFound">
                <img className="imageFound" src={notFound} alt="Imagem de página não encontrada" />
            </div>
        </MainContent>
    );
};

export default NotFoundPage;
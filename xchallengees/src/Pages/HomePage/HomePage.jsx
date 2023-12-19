import React from 'react';
import Button from '../../components/Button/Button.jsx';
import MainContent from "../../components/MainContent/MainContent.jsx"
import Input from '../../components/Input/Input.jsx';
import Title from '../../components/Title/Title.jsx';

const HomePage = () => {
    return (
        <>
        <MainContent>
            <Title titleText={"Tela da home"}/>

            <Button buttonText={"botao 1"} />

            <Input placeholder={"teste bem testado"} />
        </MainContent>
        </>
    );
};

export default HomePage;
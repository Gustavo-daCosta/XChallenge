import React from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import HomePage from './HomePage/HomePage';
import LoginPage from './LoginPage/LoginPage';
import Header from '../components/Header/Header';
import NotFoundPage from './NotFoundPage/NotFoundPage';
import ResultadoPage from './ResultadosPage/ResultadoPage';
import Modalidades from './Modalidade/ModalidadePage';

const Rotas = () => {
    return (
        <div>
            <BrowserRouter>
            <Header/>
                <Routes>
                    <Route path='/' exact element={<HomePage/>} />
                    <Route path='/LoginPage' element={<LoginPage/>}/>
                    <Route path='/Modalidades' element={<Modalidades/>}/>
                    <Route path='/Resultados' element={<ResultadoPage/>}/>
                    <Route path='*' element={<NotFoundPage/>}/>
                </Routes>
            
            </BrowserRouter>
        </div>
    );
};

export default Rotas;
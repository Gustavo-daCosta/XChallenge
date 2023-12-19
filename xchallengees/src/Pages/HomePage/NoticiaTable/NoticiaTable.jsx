import "./NoticiaTable.css"
import React from 'react';
import Title from '../../../components/Title/Title';
import NoticiaCard from '../../../components/NoticiaCard/NoticiaCard';

const NoticiaTable = ({ noticias, isShown = true }) => {


    

    return (
        <div className="noticiaSection">

            <Title titleText={"Notícias"} />

            <div className="noticiaCards">
                {isShown ? <>
                    {noticias.slice(0, 5).map(z => {
                        return (
                            <NoticiaCard title={z.titulo} data={z.data} />
                        )
                    })}
                </> : <>
                    {noticias.map(z => {
                        return (
                            <NoticiaCard title={z.titulo} data={z.data} />
                        )
                    })}
                </>}


            </div>
        </div>
    );
};

export default NoticiaTable;
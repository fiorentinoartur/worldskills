import React from 'react';
import "./ResultsPage.css";
import TableRe from './TableRe/TableRe';
import { Select } from '../../Components/FormComponents/FormComponents';
import Container from "../../Components/Container/Container"
import Main from "../../Components/Main/Main"

const ResultsPage = () => {
    return (
        <>
            <Main>
                <Container>
                    <section className='resultpage'>

                    <div className="select-flex">
                        <div className='select__item'>
                            <p>Edição</p>
                            <Select 
                            additionalClass='select-result'
                            />
                        </div>
                        <div className='select__item'>
                            <p>País</p>
                            <Select 
                             additionalClass='select-result'
                            />
                        </div>
                        <div className='select__item'>
                            <p>Modalidade</p>
                            <Select
                             additionalClass='select-result'
                            />
                        </div>

                    </div>
                    <TableRe/>
                    </section>

                </Container>
            </Main>
        </>


    );
};

export default ResultsPage;
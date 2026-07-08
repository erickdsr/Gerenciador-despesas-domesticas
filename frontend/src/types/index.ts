/** Pessoa cadastrada e retornada pela API. */
export interface Person {
  id: number
  name: string
  age: number
}

/** Dados enviados para criar uma pessoa. */
export interface CreatePersonRequest {
  name: string
  age: number
}

/** Valores aceitos pelo backend para classificar uma transacao. */
export type TransactionType = 'Expense' | 'Income'

/** Transacao financeira exibida na listagem da tela de transacoes. */
export interface FinancialTransaction {
  id: number
  description: string
  amount: number
  type: TransactionType
  personId: number
  personName: string
  createdAt: string
}

/** Dados enviados para criar uma transacao financeira. */
export interface CreateTransactionRequest {
  description: string
  amount: number
  type: TransactionType
  personId: number
}

/** Totais calculados para uma pessoa no dashboard. */
export interface PersonSummary {
  personId: number
  personName: string
  totalIncome: number
  totalExpenses: number
  balance: number
}

/** Totais consolidados de todas as pessoas e transacoes. */
export interface GeneralSummary {
  totalIncome: number
  totalExpenses: number
  netBalance: number
}

/** Resposta completa da API de resumo financeiro. */
export interface SummaryResponse {
  people: PersonSummary[]
  general: GeneralSummary
}

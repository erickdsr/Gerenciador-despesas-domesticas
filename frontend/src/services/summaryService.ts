import { api } from './api'
import type { SummaryResponse } from '../types'

// Centraliza a chamada de resumo financeiro usada pelo dashboard.
export const summaryService = {
  async getSummary(): Promise<SummaryResponse> {
    const { data } = await api.get<SummaryResponse>('/summary')
    return data
  },
}

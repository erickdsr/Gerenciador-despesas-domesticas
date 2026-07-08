import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'

// Configuracao do Vite para empacotar a SPA React.
export default defineConfig({
  plugins: [react()],
})

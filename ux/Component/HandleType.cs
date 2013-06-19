﻿/* ux - Micro Xylph / Software Synthesizer Core Library
 * Copyright (C) 2013 Tomona Nanase. All rights reserved.
 */

namespace ux.Component
{
	/// <summary>
	/// 内部で扱われるハンドルのタイプを表す列挙体です。
	/// </summary>
	public enum HandleType
	{
        /// <summary>
        /// ゼロのゲートを持ち、発音されないノートを表します。
        /// </summary>
        ZeroGate = 0,

        /// <summary>
        /// パートまたはマスターの各パラメータをリセットします。
        /// </summary>
		Reset = 1,

        /// <summary>
        /// ノートのエンベロープをサイレンス状態に移行させ、無音状態にします。
        /// </summary>
		Silence = 2,

        /// <summary>
        /// ノートのエンベロープをリリース状態に移行させます。
        /// </summary>
		NoteOff = 3,

        /// <summary>
        /// ボリューム (音量) を変更します。
        /// </summary>
		Volume = 4,

        /// <summary>
        /// エクスプレッションレベル を変更します。
        /// </summary>
        Expression = 5,	

        /// <summary>
        /// パンポット (定位) を変更します。
        /// </summary>
		Panpot = 6,

        /// <summary>
        /// ビブラートに関するパラメータを設定します。
        /// </summary>
		Vibrate = 7,

        /// <summary>
        /// パートに波形を割り当てます。
        /// </summary>
		Waveform = 8,

        /// <summary>
        /// 波形のパラメータを編集します。
        /// </summary>
		EditWaveform = 9,

        /// <summary>
        /// パートの音量エンベロープを変更します。
        /// </summary>
		Envelope = 10,

        /// <summary>
        /// パートのファインチューン値を変更します。
        /// </summary>
		FineTune = 11,

        /// <summary>
        /// パートの発音ノートキーをシフトします。
        /// </summary>
		KeyShift = 12,

        /// <summary>
        /// ポルタメント効果に関するパラメータを設定します。
        /// </summary>
		Portament = 13,

        /// <summary>
        /// パートを指定されたノートまたは周波数でアタック状態にします。
        /// </summary>
		NoteOn = 14
	}
}

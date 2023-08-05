using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System218 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component414),typeof(Component279),typeof(Component109),typeof(Component144) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
   var e = _world.NewEntity();
   ref var c1 = ref _aspect.Component119Pool.Add(e);
   ref var tick = ref _aspect.TicksCooldownComponentPool.Add(e);
   tick.Ticks=10;
  }
 }
}

}

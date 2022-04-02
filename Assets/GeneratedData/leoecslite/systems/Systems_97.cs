using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System97 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component190> _p1;
EcsPool<Component292> _p2;
EcsPool<Component111> _p3;
EcsPool<Component358> _p4;
EcsPool<Component399> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component190>().Inc<Component292>().Inc<Component111>().Inc<Component358>().End();
   _p1 = _world.GetPool<Component190>();
   _p2 = _world.GetPool<Component292>();
   _p3 = _world.GetPool<Component111>();
   _p4 = _world.GetPool<Component358>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component399>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl0.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

}

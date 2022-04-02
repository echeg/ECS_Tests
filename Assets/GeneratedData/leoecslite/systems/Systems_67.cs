using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System67 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component191> _p1;
EcsPool<Component51> _p2;
EcsPool<Component346> _p3;
EcsPool<Component338> _p4;
EcsPool<Component104> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component191>().Inc<Component51>().Inc<Component346>().Inc<Component338>().End();
   _p1 = _world.GetPool<Component191>();
   _p2 = _world.GetPool<Component51>();
   _p3 = _world.GetPool<Component346>();
   _p4 = _world.GetPool<Component338>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component104>();
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

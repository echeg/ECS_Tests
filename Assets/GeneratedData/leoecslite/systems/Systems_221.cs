using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System221 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component252> _p1;
EcsPool<Component470> _p2;
EcsPool<Component39> _p3;
EcsPool<Component383> _p4;
EcsPool<Component167> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component252>().Inc<Component470>().Inc<Component39>().Inc<Component383>().End();
   _p1 = _world.GetPool<Component252>();
   _p2 = _world.GetPool<Component470>();
   _p3 = _world.GetPool<Component39>();
   _p4 = _world.GetPool<Component383>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component167>();
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

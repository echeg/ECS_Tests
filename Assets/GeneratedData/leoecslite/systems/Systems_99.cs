using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System99 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component108> _p1;
EcsPool<Component233> _p2;
EcsPool<Component316> _p3;
EcsPool<Component357> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component108>().Inc<Component233>().Inc<Component316>().Inc<Component357>().End();
   _p1 = _world.GetPool<Component108>();
   _p2 = _world.GetPool<Component233>();
   _p3 = _world.GetPool<Component316>();
   _p4 = _world.GetPool<Component357>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

}

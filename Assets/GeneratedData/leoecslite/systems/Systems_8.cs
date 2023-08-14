using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System8 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component387> _p1;
EcsPool<Component147> _p2;
EcsPool<Component389> _p3;
EcsPool<Component295> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component387>().Inc<Component147>().Inc<Component389>().Inc<Component295>().End();
   _p1 = _world.GetPool<Component387>();
   _p2 = _world.GetPool<Component147>();
   _p3 = _world.GetPool<Component389>();
   _p4 = _world.GetPool<Component295>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

}

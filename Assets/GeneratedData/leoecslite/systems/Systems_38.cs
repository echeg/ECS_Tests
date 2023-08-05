using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System38 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component442> _p1;
EcsPool<Component415> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component442>().Inc<Component415>().End();
   _p1 = _world.GetPool<Component442>();
   _p2 = _world.GetPool<Component415>();
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

using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System4 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component133> _p1;
EcsPool<Component70> _p2;
EcsPool<Component121> _p3;
EcsPool<Component274> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component133>().Inc<Component70>().Inc<Component121>().Inc<Component274>().End();
   _p1 = _world.GetPool<Component133>();
   _p2 = _world.GetPool<Component70>();
   _p3 = _world.GetPool<Component121>();
   _p4 = _world.GetPool<Component274>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}

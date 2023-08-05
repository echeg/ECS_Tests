using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System7 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component460> _p1;
EcsPool<Component48> _p2;
EcsPool<Component485> _p3;
EcsPool<Component92> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component460>().Inc<Component48>().Inc<Component485>().Inc<Component92>().End();
   _p1 = _world.GetPool<Component460>();
   _p2 = _world.GetPool<Component48>();
   _p3 = _world.GetPool<Component485>();
   _p4 = _world.GetPool<Component92>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}

using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System104 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component301> _p1;
EcsPool<Component75> _p2;
EcsPool<Component329> _p3;
EcsPool<Component121> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component301>().Inc<Component75>().Inc<Component329>().Inc<Component121>().End();
   _p1 = _world.GetPool<Component301>();
   _p2 = _world.GetPool<Component75>();
   _p3 = _world.GetPool<Component329>();
   _p4 = _world.GetPool<Component121>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
